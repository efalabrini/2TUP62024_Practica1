// 5) Reciba una lista de números enteros y retorne una lista de sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20.
// Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”




using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        
        var listNumber = new List<int> {7, 2, 30};

        return Ok(listNumber.Select(n => Math.Pow(n, 2)).Where(n => n >= 20));

    }
}