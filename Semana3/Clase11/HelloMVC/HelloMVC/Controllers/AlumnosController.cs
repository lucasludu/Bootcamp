using HelloMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloMVC.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: AlumnosController
        public ActionResult Index()
        {
            //return View();
            var Alumnos = from a in RecuperarAlumnos()
                          orderby a.IdAlumno
                          select a;
            return View(Alumnos);
        }

        // GET: AlumnosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlumnosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlumnosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlumnosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlumnosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [NonAction] // No se va poder realizar una petición desde el navegador, sino desde el Controlador
        public List<Alumno> RecuperarAlumnos() 
        {
            return new List<Alumno>
            {
                new Alumno
                {
                    IdAlumno = 1,
                    Nombre = "Alberto",
                    ApPaterno = "Soler",
                    ApMaterno = "Romero",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 30
                },
                new Alumno
                {
                    IdAlumno = 2,
                    Nombre = "Erick",
                    ApPaterno = "Jara",
                    ApMaterno = "Luna",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    Edad = 25
                }
            };
        }
    }
}
