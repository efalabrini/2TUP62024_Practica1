//4) Reciba una lista de números enteros y retorne una lista con los 5 primeros que corresponden 
//    a la lista ingresada ordenada en orden descendente. Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj4Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] List<int> numbers)
    {
        if (numbers == null || numbers.Count() == 0)
        {
            return BadRequest("No hay numeros en la lista");
        }
        else
        {
            var sortedNumbers = numbers.OrderByDescending(num => num);
            List<int> sortedNumbersResult = sortedNumbers.ToList();
            List<int> resultElBueno = new List<int>();

            for (int i = 0; i <= 4; i++)
            {
                resultElBueno.Add(sortedNumbersResult[i]);
            }

            return Ok(resultElBueno);
        }
    }
}