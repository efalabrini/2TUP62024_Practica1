using Microsoft.AspNetCore.Mvc;

namespace web;

[ApiController]
[Route("[controller]")]
public class Ej1controller : ControllerBase
{
    [HttpGet()]
    public IActionResult Get([FromQuery] string nombre, [FromQuery] string ciudad)
    {
        string mensaje = $"Hola {nombre}, bienvenido a {ciudad}";
        return Ok(mensaje);
    }
}