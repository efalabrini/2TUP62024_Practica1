using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
using System.Linq;

[ApiController]
[Route("[controller]")]

public class LinqEj1Controller : ControllerBase
{
    [HttpGet]

    public ActionResult Get([FromQuery] List<int> numbers)
    {
        var filterNumbers = from number in numbers
                              where number >= 30 && number <= 100
                              select number;
        var result = filterNumbers.ToList();
        return Ok(result);
    }
}

//1) Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
//Ejemplo: [67, 92, 153, 15] → 67, 92
