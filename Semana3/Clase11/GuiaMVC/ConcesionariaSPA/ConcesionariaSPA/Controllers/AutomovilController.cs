using ConcesionariaSPA.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConcesionariaSPA.Controllers
{
    public class AutomovilController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        private static List<Automovil> listaAuto = new List<Automovil>();

        #region ListaAutomoviles
        // GET: Automovil
        public ActionResult Index()
        {
            listaAuto = new List<Automovil>();
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
                        nuevoAuto.Kilometro = Convert.ToInt32(dr["kilometro"]);
                        nuevoAuto.Precio = Convert.ToDouble(dr["precio"]);

                        listaAuto.Add(nuevoAuto);
                    }
                }

            }
            return View(listaAuto);
        }
        #endregion ListaAutomoviles

        [HttpGet] /* Devuelve la vista */
        public ActionResult RegistrarAuto()
        {
            return View();
        }

        #region RegistrarAuto
        [HttpPost]
        public ActionResult RegistrarAuto(Automovil automovil)
        {
            using(SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("RegistrarAutomovil", connection);
                cmd.Parameters.AddWithValue("marca", automovil.Marca);
                cmd.Parameters.AddWithValue("modelo", automovil.Modelo);
                cmd.Parameters.AddWithValue("anio", automovil.Anio);
                cmd.Parameters.AddWithValue("kilometro", automovil.Kilometro);
                cmd.Parameters.AddWithValue("precio", automovil.Precio);

                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Automovil");
        }
        #endregion RegistrarAutos



    }
}