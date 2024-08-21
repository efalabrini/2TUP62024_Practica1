using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumber()
        {
            var numeros = new List<int>();
            int i = 1;

            // Recorrer los números del 1 al 100 usando un bucle while
            while (i <= 100)
            {
                numeros.Add(i);
                i++;
            }

            // Devolver los números como una respuesta JSON
            return Ok(numeros);
        }
    }
}