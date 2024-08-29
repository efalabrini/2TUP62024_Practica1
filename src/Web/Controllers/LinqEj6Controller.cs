using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj6Controller : ControllerBase
{

    [HttpGet(Name = "action")]
    public ActionResult Get([FromQuery] string[] words)
    {
        var Query = words.Select(word => word.Replace("ia", "*"));

        return Ok(Query);   
    }
}

/*
 6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"

*/