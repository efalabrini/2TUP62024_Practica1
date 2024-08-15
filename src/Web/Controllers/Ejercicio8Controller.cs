using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            if ((fin - inicio) >= 1000)
            {
                return BadRequest("La diferencia debe ser menor a 1000");
            }

            var numbers = new List<int>();
            int current = inicio;

            while (current <= fin)
            {
                numbers.Add(current);
                current++;
            }

            return Ok(numbers);
        }
    }
}