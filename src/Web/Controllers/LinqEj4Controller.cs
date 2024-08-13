// 4) Reciba una lista de números enteros y retorne una lista con los 5 primeros que corresponden a la lista ingresada ordenada en orden descendente.
// Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21



using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj4Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        
        var listNumber = new List<int> {78, -9, 0, 23, 54,  21, 7, 86};

        return Ok(listNumber.OrderByDescending(n => n).Where((n, Index) => Index < 5));

    }
}