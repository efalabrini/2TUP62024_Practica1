using Microsoft.AspNetCore.Mvc;
using System.Linq;

/* 
4) Reciba una lista de números enteros y retorne una lista con los 5 primeros que corresponden a la lista ingresada ordenada en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
*/

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class LinqEj4Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get([FromQuery] List<int> numeros)
    {
        var listaNumeros = numeros.OrderByDescending(x => x).Take(5).ToList();
        return Ok(listaNumeros);
    }
}