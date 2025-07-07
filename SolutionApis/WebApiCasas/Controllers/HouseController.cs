using CapaNegocio;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        [HttpGet("v3/ViewHouse")]
        public Task<Casa> ObtenerCasa([FromQuery] int Id)
        {
            NgCasa ngCasa = new NgCasa();
            Casa casa = ngCasa.ObtenerCasa(Id);
            return Task.FromResult(casa);
        }

        [HttpGet("v3/ViewHouses")]
        public Task<List<Casa>> ObtenerCasas()
        {
            NgCasa ngCasa = new NgCasa();
            List<Casa> casas = ngCasa.ObtenerCasas();
            return Task.FromResult(casas);
        }

        [HttpDelete("v3/DeleteCasas")]
        public Task<IActionResult> EliminarCasa([FromQuery] int Id)
        {
            NgCasa ngCasa = new NgCasa();
            ngCasa.EliminarCasa(Id);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpPut("v3/UpdateHouses")]    
        public Task<IActionResult> ActualizarCasa([FromBody] Casa casa)
        {
            NgCasa ngCasa = new NgCasa();
            ngCasa.ActualizarCasa(casa);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpPost("v3/AddHouse")]
        public Task<IActionResult> AgregarCasa([FromBody] Casa casa)
        {
            NgCasa ngCasa = new NgCasa();
            ngCasa.AgregarCasa(casa);
            return Task.FromResult<IActionResult>(Ok());
        }
    }
}
