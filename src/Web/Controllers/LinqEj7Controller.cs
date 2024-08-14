using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] string texto)
    {
        var resultado = (from palabra in texto.Split(' ')
                         where palabra.All(char.IsUpper) 
                         select palabra).ToList();

        return Ok(resultado);
    }
}