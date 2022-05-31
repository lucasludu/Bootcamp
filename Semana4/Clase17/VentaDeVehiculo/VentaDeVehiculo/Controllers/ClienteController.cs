using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.Diagnostics;
using VentaDeVehiculo.Models;
using VentaDeVehiculo.UOWork;

namespace VentaDeVehiculo.Controllers
{
    [Tags("Api de Cliente")]
    [Route("api/[controller]")]
    [ApiController]
    ///<sumary></sumary>
    public class ClienteController : ControllerBase
    {

        private readonly IUnitOfWork _context;

        public ClienteController(IUnitOfWork context) 
        {
            _context = context;
        }

        /// <summary>
        /// Muestra a todos los clientes
        /// </summary>
        /// <returns>Cliente</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var entidad = _context.ClienteRepo.GetAll();
            return Ok(entidad);
        }

        /// <summary>
        /// Crea el cliente
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="cliente">Cliente a ingresar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(Cliente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            _context.ClienteRepo.Insert(cliente);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Modifica al cliente
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="id" example="123">Cliente a modificar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cliente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Put([FromBody] Cliente cliente, int? id)
        {
            if(id != cliente.Id)
            {
                return BadRequest();
            }
            _context.ClienteRepo.Update(cliente);
            _context.Save();
            return Ok();
        }

        /// <summary>
        /// Elimina al cliente
        /// </summary>
        /// <remarks>Awesomeness!</remarks>
        /// <param name="id" example="123">Cliente a eliminar</param>
        /// <response code="200">Created. Objeto correctamente creado en la BBDD</response>
        /// <response code="400">BadRequest. No se ha creado el objeto en la BBDD. Formato del objeto incorrecto</response>
        /// <response code="500">Unauthorized. Error interno dentro de la funcion</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Cliente))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Cliente> Delete(int id)
        {
            var entity = _context.ClienteRepo.GetById(id);
            if(entity == null)
            {
                return NotFound();
            }
            _context.ClienteRepo.Delete(id);
            _context.Save();

            return entity;
        }

    }
}
