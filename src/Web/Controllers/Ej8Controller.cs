using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            int i = inicio;
            while (i <= fin)
            {
                numeros.Add(i);
                i++;
            }
           

            return Ok(numeros);
        }
    }
}