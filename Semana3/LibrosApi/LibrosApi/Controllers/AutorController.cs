using LibrosApi.Data;
using LibrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrosApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {

        public readonly UnitOfWork _uOw;

        public AutorController(UnitOfWork uOw)
        {
            _uOw = uOw;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            //return _uOw.Autors.Include(x => x.Libros).ToList();
            return _uOw.Autors.Include(x => x.Libros).ToList();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            _context.Autors.Add(autor);
            _context.SaveChanges();
            return new CreatedAtRouteResult("Autor", new { id = autor.Id }, autor);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Autor autor, int id)
        {
            if(id != autor.Id)
            {
                return BadRequest();
            }
            _context.Entry(autor).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{numero}")]
        public ActionResult<Autor> Delete(int numero)
        {
            var autor = _context.Autors.FirstOrDefault(x => x.Id == numero);
            if(autor == null)
            {
                return NotFound();
            }
            _context.Entry(autor).State = EntityState.Deleted;
            _context.SaveChanges();

            return autor;
        }

        [HttpGet("{id}")]
        public ActionResult<Autor> FindId(int id)
        {
            var autor = _context.Autors.Where(
                x => x.Id == id)
                .Include(x => x.Libros).First();
            if(autor == null)
            {
                return NotFound();
            }

            return autor;
        }


        [HttpGet("/find/{nombre}")]
        public ActionResult<IEnumerable<Autor>> FindByName(string nombre)
        {
            var autor = _context.Autors.Where(
                x=>string.Equals(x.Nombre, nombre)
                ).ToList();

            return autor;
        }



    }
}
