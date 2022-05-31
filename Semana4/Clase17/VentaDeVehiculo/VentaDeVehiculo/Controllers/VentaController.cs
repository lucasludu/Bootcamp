using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaDeVehiculo.Models;
using VentaDeVehiculo.UOWork;

namespace VentaDeVehiculo.Controllers
{
    [Tags("Api de Venta")]
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public VentaController(IUnitOfWork context)
        {
            _context = context;
        }

        /// <summary>
        /// Muestra toda la venta
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Venta>> Get()
        {
            var entidad = _context.VentaRepo.GetAll();
            return Ok(entidad);
        }

        /// <summary>
        /// Crea la venta
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="venta">Venta a ingresar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Venta))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Post([FromBody] Venta venta)
        {
            _context.VentaRepo.Insert(venta);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Modifica a la venta
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="id" example="123">Venta a modificar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Venta))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Put([FromBody] Venta venta, int? id)
        {
            if (id != venta.Id)
            {
                return BadRequest();
            }
            _context.VentaRepo.Update(venta);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Elimina a la venta
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="id" example="123">Venta a eliminar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Venta))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Venta> Delete(int id)
        {
            var entity = _context.VentaRepo.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.VentaRepo.Delete(id);
            _context.Save();

            return entity;
        }
    }
}
