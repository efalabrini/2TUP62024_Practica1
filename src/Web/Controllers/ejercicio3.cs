// 3) Reciba un nombre y un valor de edad y retorne el siguiente mensaje:
// “Te llamas ” <nombre> ” y tienes ” <años> ” años”

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controllers : ControllerBase
{

    [HttpGet]
    public string Get(string nombre, int edad)
    {
        return $"Te llamas {nombre} y tienes {edad} años";
        
    }
}
