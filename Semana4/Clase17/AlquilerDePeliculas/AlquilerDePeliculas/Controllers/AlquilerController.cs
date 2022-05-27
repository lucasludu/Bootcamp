using AlquilerDePeliculas.Models;
using AlquilerDePeliculas.UOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlquilerDePeliculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {
        private readonly IUnitOfWork _uOw;

        public AlquilerController(IUnitOfWork uOw)
        {
            this._uOw = uOw;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Alquiler>> Get()
        {
            var alq = _uOw.AlquileresR.GetAll();
            return Ok(alq);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Alquiler alquiler)
        {
            _uOw.AlquileresR.Insert(alquiler);
            _uOw.Save();
            return new CreatedAtRouteResult("Alquiler", new { id = alquiler.Id }, alquiler);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Alquiler alquiler, int id)
        {
            if (id != alquiler.Id)
            {
                return BadRequest();
            }
            _uOw.AlquileresR.Update(alquiler);
            _uOw.Save();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Alquiler> Delete(int id)
        {
            var alq = _uOw.AlquileresR.GetById(id);
            if (alq == null)
            {
                return NotFound();
            }
            _uOw.AlquileresR.Delete(id);
            _uOw.Save();

            return alq;
        }
    }
}
