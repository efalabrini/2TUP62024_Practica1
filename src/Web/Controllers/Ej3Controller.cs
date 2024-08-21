using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej3Controller : ControllerBase
{
    [HttpGet]

       public IActionResult Get([FromQuery] string nombre, [FromQuery] int edad)
    {
        string mensaje = $"Te llamas {nombre} y tienes {edad} años.";
        
        return Ok(mensaje);
    }
  
}