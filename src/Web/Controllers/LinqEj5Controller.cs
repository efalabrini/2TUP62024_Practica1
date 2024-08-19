//5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" 
//    sólo si el cuadrado es mayor que 20
//Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”



using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numbers)
    {
        if (numbers == null || numbers.Count() == 0)
        {
            return BadRequest("No se ingresaron numeros");
        }
        else
        {
            var nums = numbers.Where(num => num * num > 20);
            Dictionary<int,int> numsSelected = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!numsSelected.ContainsKey(num))
                {
                    numsSelected.Add(num, num * num);
                }
            }
            return Ok(numsSelected);
        }

    }
}