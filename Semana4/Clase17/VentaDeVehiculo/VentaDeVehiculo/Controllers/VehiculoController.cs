using Microsoft.AspNetCore.Mvc;
using VentaDeVehiculo.Models;
using VentaDeVehiculo.UOWork;

namespace VentaDeVehiculo.Controllers
{
    [Tags("Api de Vehiculo")]
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public VehiculoController(IUnitOfWork context)
        {
            _context = context;
        }

        /// <summary>
        /// Muestra todos los vehiculos
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Vehiculo>> Get()
        {
            var entidad = _context.VehiculoRepo.GetAll();
            return Ok(entidad);
        }

        /// <summary>
        /// Crea el vehiculo
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="vehiculo">Vehiculo a ingresar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vehiculo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Post([FromBody] Vehiculo vehiculo)
        {
            _context.VehiculoRepo.Insert(vehiculo);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Modifica el vehiculo
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="id" example="123">Vehiculo a modificar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vehiculo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Put([FromBody] Vehiculo vehiculo, int? id)
        {
            if (id != vehiculo.Id)
            {
                return BadRequest();
            }
            _context.VehiculoRepo.Update(vehiculo);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Elimina al vehiculo
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="id" example="123">Vehiculo a eliminar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Vehiculo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Vehiculo> Delete(int id)
        {
            var entity = _context.VehiculoRepo.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.VehiculoRepo.Delete(id);
            _context.Save();

            return entity;
        }
    }
}
