using ProyectoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
 

namespace ProyectoCRUD.Controllers
{
    public class ContactoController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();


        private static List<Contacto> oLista = new List<Contacto>();

        // GET: Contacto
        public ActionResult Inicio()
        {
            oLista = new List<Contacto>();
            using(SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Contacto", connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        Contacto nuevoContacto = new Contacto();

                        nuevoContacto.idContacto = Convert.ToInt32(dr["idContacto"]);
                        nuevoContacto.nombre = dr["nombre"].ToString();
                        nuevoContacto.apellido = dr["apellido"].ToString();
                        nuevoContacto.telefono = dr["telefono"].ToString();
                        nuevoContacto.correo = dr["correo"].ToString();

                        oLista.Add(nuevoContacto);
                    }
                }
            }
            return View(oLista);
        }

        [HttpGet] /* Devuelve la vista */
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost] /* Devuelve la vista con el resultado */
        public ActionResult Registrar(Contacto oContacto)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Registrar", connection);
                cmd.Parameters.AddWithValue("nombre", oContacto.nombre);
                cmd.Parameters.AddWithValue("apellido", oContacto.apellido);
                cmd.Parameters.AddWithValue("telefono", oContacto.telefono);
                cmd.Parameters.AddWithValue("correo", oContacto.correo);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery(); /* Ejecuta todo lo anterior */
            }
            return RedirectToAction("Inicio","Contacto");
        }

        [HttpGet] 
        public ActionResult Editar(int? idContacto)
        {
            if(idContacto == null)
            {
                return RedirectToAction("Inicio", "Contacto");
            }
            Contacto oContacto = oLista.Where(c => c.idContacto == idContacto).FirstOrDefault();
            return View(oContacto);
        }

        [HttpPost] 
        public ActionResult Editar(Contacto oContacto)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Editar", connection);
                cmd.Parameters.AddWithValue("idContacto", oContacto.idContacto);
                cmd.Parameters.AddWithValue("nombre", oContacto.nombre);
                cmd.Parameters.AddWithValue("apellido", oContacto.apellido);
                cmd.Parameters.AddWithValue("telefono", oContacto.telefono);
                cmd.Parameters.AddWithValue("correo", oContacto.correo);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery(); /* Ejecuta todo lo anterior */
            }
            return RedirectToAction("Inicio", "Contacto");
        }


        [HttpGet]
        public ActionResult Eliminar(int? idContacto)
        {
            if (idContacto == null)
            {
                return RedirectToAction("Inicio", "Contacto");
            }
            Contacto oContacto = oLista.Where(c => c.idContacto == idContacto).FirstOrDefault();
            return View(oContacto);
        }

        [HttpPost]
        public ActionResult Eliminar(string idContacto)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Eliminar", connection);
                cmd.Parameters.AddWithValue("idContacto", idContacto);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                cmd.ExecuteNonQuery(); 
            }
            return RedirectToAction("Inicio", "Contacto");
        }
    }
}