//6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada.
//   Para simplificar escribir todo sin acento. Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"

using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj6controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery]List<string> strings)
    {

        var s = strings.Select(str => str.Replace("ia", "*"));

        return Ok(s);

    }
}
