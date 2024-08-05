using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    [HttpGet]
    public string Get(string nombre, string ciudad)
    {
        return $"Hola {nombre} bienvenido a {ciudad}";
    }
}
//2) Reciba el nombre de una persona y el nombre de una ciudad, y retorne el siguiente mensaje:
//“Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación.