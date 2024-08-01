using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    [HttpGet("[action]")]
    public string GetSaludoCuidad([FromQuery] string name, string city)
    {
        return $"Hola {name}, bienvenido a {city}.";
    }
}
