using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumeroMayor(int numero1, int numero2)
        {
            int mayor = numero1 > numero2 ? numero1 : numero2;
            return Ok("El número mayor es: "+ mayor);
        }
    }
}