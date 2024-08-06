using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    [HttpGet]
    public string Get(string name, string city)
    {
        return $"Hola {name}, bienvenido a {city}";
    }
}