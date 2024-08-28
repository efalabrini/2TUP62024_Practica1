using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumeros()
        {
            var numeros = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                numeros.Add(i);
            }

            return Ok(numeros);
        }
    }
}
