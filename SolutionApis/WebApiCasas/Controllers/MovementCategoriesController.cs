using Microsoft.AspNetCore.Mvc;
using Entities;
using CapaNegocios;

namespace WebApiCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovementCategoriesController : ControllerBase
    {
        [HttpPost("AddMovementCategory")]
        public Task<IActionResult> AgregarCategoriaMovimientos([FromBody] CategoriaMovimientos categoria)
        {
            NgCategoriaMovimientos ngCategoriaMovimientos = new NgCategoriaMovimientos();
            ngCategoriaMovimientos.AgregarCategoriaMovimientos(categoria);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpPut("UpdateMovementCategory")]
        public Task<IActionResult> ActualizarCategoriaMovimientos([FromBody] CategoriaMovimientos categoria)
        {
            NgCategoriaMovimientos ngCategoriaMovimientos = new NgCategoriaMovimientos();
            ngCategoriaMovimientos.ActualizarCategoriaMovimientos(categoria);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpDelete("DeleteMovementCategory")]
        public Task<IActionResult> EliminarCategoriaMovimientos([FromQuery] int Id)
        {
            NgCategoriaMovimientos ngCategoriaMovimientos = new NgCategoriaMovimientos();
            ngCategoriaMovimientos.EliminarCategoriaMovimientos(Id);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpGet("GetMovementCategory")]
        public Task<CategoriaMovimientos> MostrarCategoriaMovimientos([FromQuery] int Id)
        {
            NgCategoriaMovimientos ngCategoriaMovimientos = new NgCategoriaMovimientos();
            CategoriaMovimientos categoria = ngCategoriaMovimientos.MostrarCategoriaMovimientos(Id);
            return Task.FromResult(categoria);
        }
    }
}
