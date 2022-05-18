using Concesionaria.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concesionaria.Controllers
{
    public class AutomovilController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        private static List<Automovil> oLista = new List<Automovil>();


        // GET: Automovil
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListaAutomoviles()
        {
            oLista = new List<Automovil>();
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Automovil", connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Automovil nuevoAuto = new Automovil();

                        nuevoAuto.IdAuto = Convert.ToInt32(dr["idAuto"]);
                        nuevoAuto.Marca = dr["marca"].ToString();
                        nuevoAuto.Modelo = dr["modelo"].ToString();
                        nuevoAuto.Anio = Convert.ToInt32(dr["anio"]);
                        nuevoAuto.Kilometro = Convert.ToInt32(dr["kilometro"].ToString());
                        nuevoAuto.Precio = Convert.ToDouble(dr["precio"].ToString());

                        oLista.Add(nuevoAuto);
                    }
                }
            }
            return View(oLista);
        }



        [HttpGet] /* Devuelve la vista */
        public ActionResult RegistrarAutomovil()
        {
            return View();
        }

        [HttpPost] /* Devuelve la vista con el resultado */
        public ActionResult RegistrarAutomovil(Automovil automovil)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("RegistrarAutomovil", connection);
                cmd.Parameters.AddWithValue("marca", automovil.Marca);
                cmd.Parameters.AddWithValue("modelo", automovil.Modelo);
                cmd.Parameters.AddWithValue("anio", automovil.Anio);
                cmd.Parameters.AddWithValue("kilometro", automovil.Kilometro);
                cmd.Parameters.AddWithValue("precio", automovil.Precio);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery(); /* Ejecuta todo lo anterior */
            }
            return RedirectToAction("ListaAutomoviles", "Home");
        }



        [HttpGet]
        public ActionResult EditarAutomovil(int? idAuto)
        {
            if (idAuto == null)
            {
                return RedirectToAction("ListaAutomoviles", "Home");
            }
            Automovil automovil = oLista.Where(a => a.IdAuto == idAuto).FirstOrDefault();
            return View(automovil);
        }



        [HttpPost]
        public ActionResult EditarAutomovil(Automovil automovil)
        {
            using(SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("EditarAutomovil", connection);
                cmd.Parameters.AddWithValue("idAuto", automovil.IdAuto);
                cmd.Parameters.AddWithValue("marca", automovil.Marca);
                cmd.Parameters.AddWithValue("modelo", automovil.Modelo);
                cmd.Parameters.AddWithValue("anio", automovil.Anio);
                cmd.Parameters.AddWithValue("kilometro", automovil.Kilometro);
                cmd.Parameters.AddWithValue("precio", automovil.Precio);

                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("ListaAutomoviles", "Automovil");
        }



        [HttpGet]
        public ActionResult EliminarAuto(int? idAuto)
        {
            if (idAuto == null)
            {
                return RedirectToAction("ListaAutomoviles", "Automovil");
            }
            Automovil automovil = oLista.Where(a => a.IdAuto == idAuto).FirstOrDefault();
            return View(automovil);
        }

        [HttpPost]
        public ActionResult EliminarAuto(string idAuto)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("EliminarAutomovil ", connection);
                cmd.Parameters.AddWithValue("idAuto", idAuto);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("ListaAutomoviles", "Automovil");
        }
    }
}