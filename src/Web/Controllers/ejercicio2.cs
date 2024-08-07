// 2) Pedir por parámetro un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por consola el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación.


using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controllers : ControllerBase
{

    [HttpGet]
    public string Get(string nombre, string ciudad)
    {
        return $"Hola {nombre} bienvenido a {ciudad}";
        
    }
}
