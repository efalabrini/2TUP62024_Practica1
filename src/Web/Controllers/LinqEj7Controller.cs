// 7) Reciba una cadena de texto y retorne una lista con las palabras que están completamente en mayúsculas.
// Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO



using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj7Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        
        var text = "ESTO es un EJEMPLO del EJERcicio";

        var textIndividual = text.Split(' ');

        

        return Ok(textIndividual.Where(word => word == word.ToUpper()));

    }
}