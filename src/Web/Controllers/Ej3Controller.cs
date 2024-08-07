using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public string Get(string name, int age)
    {
        return $"Te llamas {name} y tienes {age} años";
    }
}