// 1) Reciba una lista de números enteros, un valor entero llamado min y un valor entero llamado max,
//  y retorne una lista con los números mayores o iguales que min y menores o iguales que max.




using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get(int min, int max)
    {
        var listNumber = new List<int> {10, 5, 40, 35, 30, 22, 29, 25, 18};
       
        return Ok(listNumber.Where(num => num >= min && num <= max));

    }
}