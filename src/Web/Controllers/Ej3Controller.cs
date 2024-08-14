using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3controller : ControllerBase
{

    [HttpGet]
    public string Get(string nombre, int edad)
    {


        return $"Hola {nombre}, tienes {edad} años";
    }
}
