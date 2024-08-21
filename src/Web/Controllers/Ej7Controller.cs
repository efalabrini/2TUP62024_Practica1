using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RangoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            if (Math.Abs(fin - inicio) >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numeros = new List<int>();

            for (int i = inicio; i <= fin; i++)
            {
                numeros.Add(i);
            }

            return Ok(numeros);
        }
    }
}
