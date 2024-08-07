using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej2Controller : ControllerBase
{
    [HttpGet]

    public string Get(string nombre, string ciudad){
        return $"Hola {nombre} bienvenido a {ciudad}";
    }
}