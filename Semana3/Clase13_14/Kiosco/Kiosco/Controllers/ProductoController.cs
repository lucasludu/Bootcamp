using Kiosco.Data;
using Kiosco.Models;
using Kiosco.Repository.Class;
using Microsoft.AspNetCore.Mvc;

namespace Kiosco.Controllers
{
    public class ProductoController : Controller
    {
        UnitOfWork uOw;

        public ProductoController(ApplicationDbContext context)
        {
            uOw = new UnitOfWork(context);
        }

        public IActionResult Index()
        {
            var producto = uOw.ProductoRepository.GetAll();
            return View(producto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                uOw.ProductoRepository.Insert(producto);
                uOw.SaveChanges();
                return RedirectToAction("Index", "Producto");
            }
            return View(producto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(id == null || uOw.ProductoRepository == null)
            {
                return NotFound();
            }
            var producto = uOw.ProductoRepository.GetById(id);
            if(producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpPost]
        public IActionResult Edit(int id, Producto producto)
        {
            if(id != producto.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                uOw.ProductoRepository.Update(producto);
                uOw.SaveChanges();
                return RedirectToAction("Index", "Producto");
            }
            return View(producto);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if(id == null || uOw.ProductoRepository == null)
            {
                return NotFound();
            }

            var producto = uOw.ProductoRepository.GetById(id);

            if(producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null || uOw.ProductoRepository == null)
            {
                return NotFound();
            }

            var producto = uOw.ProductoRepository.GetById(id);

            if(producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if(uOw.ProductoRepository == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Producto' is Null");
            }

            var producto = uOw.ProductoRepository.GetById(id);

            if(producto != null)
            {
                uOw.ProductoRepository.Delete(id);
            }

            uOw.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
