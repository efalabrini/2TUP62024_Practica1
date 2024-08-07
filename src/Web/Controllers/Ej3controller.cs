using Microsoft.AspNetCore.Mvc;

namespace web;

[ApiController]
[Route("[controller]")]
public class Ej3controller : ControllerBase
{
    [HttpGet()]
    public string Get([FromQuery] string nombre, [FromQuery] int edad)
    {
        return $"Te llamas {nombre} y tienes {edad} años";
    }
}