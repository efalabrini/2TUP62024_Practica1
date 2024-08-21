using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            if (Math.Abs(fin - inicio) >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            int current = inicio;

            while (current <= fin)
            {
                if (current % 2 == 0)
                {
                    numerosPares.Add(current);
                }
                else
                {
                    numerosImpares.Add(current);
                }
                current++;
            }

            var resultado = new 
            {
                Pares = numerosPares,
                Impares = numerosImpares
            };

            return Ok(resultado);
        }
    }
}
