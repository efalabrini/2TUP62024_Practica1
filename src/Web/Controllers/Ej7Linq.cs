using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej7Linq : ControllerBase
{
    [HttpGet]
    public ActionResult Get(string cadena)
    {
        var result = (from word in cadena.Split(' ')
                     where word.All(char.IsUpper)
                     select word).ToList();

        return Ok(result);                

    }
}