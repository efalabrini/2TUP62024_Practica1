using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{
    
    [HttpGet(Name = "action")]
    public ActionResult Get()
    {
        List<int> numbers = new List<int>{7, 2, 30, 9, 13};
        
        var Query = numbers
                .Select(num => new { Numero = num, Cuadrado = num * num })
                .Where(x => x.Cuadrado > 20)
                .Select(x => $"{x.Numero} - {x.Cuadrado}");

        return Ok(Query);

    }
}

/*
 5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
 Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”
*/