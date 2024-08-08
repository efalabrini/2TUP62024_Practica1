using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ejercicio2 : ControllerBase
{
    [HttpGet]
    public string Get(string name, string city){
        return $"Hola {name}, bienvenido a {city}";
    }
}
