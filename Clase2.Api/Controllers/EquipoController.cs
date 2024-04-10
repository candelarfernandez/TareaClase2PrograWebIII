using Clase.Logica;
using Clase2.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        IEquipoServicio _equipoServicio;
        public EquipoController(IEquipoServicio equipoServicio)
        {
            _equipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_equipoServicio.GetEquipos());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Equipo equipo)
        {
            _equipoServicio.Agregar(equipo);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
       
        public IActionResult Delete([FromBody] int idEquipo)
        {
            _equipoServicio.Eliminar(idEquipo);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
