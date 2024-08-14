using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ej2controller : ControllerBase
{

    [HttpGet]
    public string Get(string nombre, string ciudad)
    {


        return $"Hola {nombre}, Bienvenido a {ciudad}";
    }
}
