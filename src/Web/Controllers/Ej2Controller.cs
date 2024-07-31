using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    [HttpGet]
    public string Get([FromQuery] string name, [FromQuery] string city)
    {
        return $"Hola {name} bienvenido a {city}";
    }
}
