// 6) Reciba una lista de palabras y  retorne una lista que sustituya la cadena 'ia' por el asterisco (*) en cada palabra dada. Para simplificar escribir todo sin acento.
// Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"





using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj6Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        
        var listWord = new List<string> {"estudiar", "caminar", "dia"};

        return Ok(listWord.Select(letter => letter.Replace("ia", "*")));

    }
}