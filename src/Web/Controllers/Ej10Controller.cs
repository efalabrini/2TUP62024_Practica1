using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int fin)
        {
            if (Math.Abs(fin - inicio) >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numeros = new List<int>();
            List<int> num2 = new List<int>();
            int i = inicio;
            while (i <= fin)
            {
                if(i % 2 == 0)
                {
                    numeros.Add(i);
                    
                }else
                {
                    num2.Add(i);
                }
                 i++;
            }
           

             return Ok(new { Pares = numeros, Impares = num2 });
        }
    }
}