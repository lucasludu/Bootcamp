 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudEntityMVC.Models;

namespace CrudEntityMVC.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                using(CursoEntityMVCEntities db = new CursoEntityMVCEntities())
                {
                    var lista = from d in db.Usuario 
                                where d.email == user && d.password == password && d.idState == 1
                                select d.idState;
                    if(lista.Count() > 0)
                    {
                        Session["Usuario"] = lista.First();
                    }
                }
                return Content("1");
            }
            catch(Exception ex)
            {
                return Content("Ocurrio un error. " + ex.Message);
            }
        }

    }
}