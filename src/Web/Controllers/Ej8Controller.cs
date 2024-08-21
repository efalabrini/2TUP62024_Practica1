using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            if (Math.Abs(fin - inicio) >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numeros = new List<int>();

            int current = inicio;

            while (current <= fin)
            {
                numeros.Add(current);
                current++;
            }

            return Ok(numeros);
        }
    }
}
