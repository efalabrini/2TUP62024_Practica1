using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public string Get([FromQuery] int number1, [FromQuery] int number2)
    {
        return number1 > number2 ? $"El numero 1: ({number1}) Es mas grande" : $"El numero 2: ({number2}) Es mas grande";
    }
}
