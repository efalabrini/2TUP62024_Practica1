// Reciba un nombre y un valor de edad y retorne el siguiente mensaje:
// “Te llamas ” <nombre> ” y tienes ” <años> ” años”


using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class ej3Controller : ControllerBase
{
    [HttpGet]
    public int Get(string name, int age)
    {
        return ($"Te llamas {name} y tienes {age} años");
    }
}