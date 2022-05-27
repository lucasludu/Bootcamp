using AlquilerDePeliculas.Models;
using AlquilerDePeliculas.UOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AlquilerDePeliculas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculaController : ControllerBase
    {
        private readonly IUnitOfWork _uOw;

        public PeliculaController(IUnitOfWork uOw)
        {
            this._uOw = uOw;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pelicula>> Get()
        {
            var peli = _uOw.PeliculasR.GetAll();
            return Ok(peli);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Pelicula pelicula)
        {
            _uOw.PeliculasR.Insert(pelicula);
            _uOw.Save();
            return new CreatedAtRouteResult("Pelicula", new { id = pelicula.Id }, pelicula);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Pelicula pelicula, int id)
        {
            if(id != pelicula.Id)
            {
                return BadRequest();
            }
            _uOw.PeliculasR.Update(pelicula);
            _uOw.Save();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Pelicula> Delete(int id)
        {
            var peli = _uOw.PeliculasR.GetById(id);
            if(peli == null)
            {
                return NotFound();
            }
            _uOw.PeliculasR.Delete(id);
            _uOw.Save();

            return peli;
        }

        
    }
}
