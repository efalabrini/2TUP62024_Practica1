using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ7Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumbers()
        {
            var numeros = new List<int>();

            // Recorrer los números del 1 al 100
            for (int i = 1; i <= 100; i++)
            {
                numeros.Add(i);
            }

            // Devolver los números como una respuesta JSON
            return Ok(numeros);
        }
    }
}
