using CapaNegocio;
using CapaNegocios;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCasas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonArea : ControllerBase
    {

        [HttpDelete("v3/DeleteCommonArea")]
        public Task<IActionResult> EliminarAreaComun([FromQuery] int Id)
        {
            NgAreaComun ngareacomun = new NgAreaComun();
            ngareacomun.EliminarAreaComun(Id);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpGet("v3/")]
        public Task<AreaComun> ObtenerAreaComun([FromQuery]int Id)
        {
            NgAreaComun ngareacomun = new NgAreaComun();
            AreaComun areacomun = ngareacomun.ObtenerAreaComun(Id);
            return  Task.FromResult(areacomun);
        }
        [HttpPut("v3/UpdateCommonArea")]
        public Task<IActionResult> ActualizarAreaComun([FromBody] AreaComun areacomun)
        {
            NgAreaComun ngareacomun = new NgAreaComun();
            ngareacomun.ActualizarAreaComun(areacomun);
            return Task.FromResult<IActionResult>(Ok());
        }

        [HttpPost ("post")]
        public Task<IActionResult> AgregarAreaComun([FromBody] AreaComun areacomun) 
        {
            NgAreaComun ngareacomun = new NgAreaComun();
            ngareacomun.AgregarAreaComun(areacomun);
            return Task.FromResult<IActionResult>(Ok());
        }


    }
}
