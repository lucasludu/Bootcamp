using LibrosApi.Data;
using LibrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibrosApi.Repository;
using LibrosApi.Repository.Interfaces;

namespace LibrosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {

        public readonly IUnitOfWork _uOw;

        public LibrosController(IUnitOfWork uOw)
        {
            this._uOw = uOw;
        }

        [HttpGet]
        public ActionResult<List<Libro>> Get()
        {
            var aux = _uOw.libroRepository.GetAutoresYLibros();
            return Ok(libros);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Libro libro)
        {
            _uOw.librosRepo.Insert(libro);
            _uOw.Save();
            return new CreatedAtRouteResult("Autor", new { id = libro.Id }, libro);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Libro libro, int id)
        {
            if (id != libro.Id)
            {
                return BadRequest();
            }
            _uOw.librosRepo.Update(libro);
            _uOw.Save();
            return Ok();
        }

        [HttpDelete("{numero}")]
        public ActionResult<Libro> Delete(int numero)
        {
            var libro = _uOw.librosRepo.GetById(numero);
            if (libro == null)
            {
                return NotFound();
            }
            _uOw.librosRepo.Delete(numero);
            _uOw.Save();
            return libro;
        }

        [HttpGet("{id}")]
        public ActionResult<Libro> GetId(int id)
        {
            try
            {
                var libros = _uOw.librosRepo.GetById(id);
                if(libros != null)
                {
                    return Ok(libros);
                }
                else
                {
                    return NotFound();
                }
            } 
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
        }

    }
}
