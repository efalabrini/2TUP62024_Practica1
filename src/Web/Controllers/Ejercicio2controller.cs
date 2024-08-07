using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

//2) Reciba el nombre de una persona y el nombre de una ciudad, y retorne el siguiente mensaje:
//“Hola ” <nombre> ” bienvenido a ” <ciudad>”.

[ApiController]
[Route("[controller]")]
public class Ejercicio2controller : ControllerBase
{

    [HttpGet]
    public string Get(string nombre, string ciudad)
    {


        return $"Hola {nombre}, Bienvenido a {ciudad}";
    }
}