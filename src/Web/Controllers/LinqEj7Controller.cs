

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj7Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(string frase)
    {
        
        // string[] lista = frase.Split(' ');
        var lista = new List<string> {};
        lista.AddRange(frase.Split(' '));
      
        return Ok(lista.Where(word => word == word.ToUpper()));
    }
}