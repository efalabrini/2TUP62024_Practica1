using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public string Get(string name, int age)
    {
        return $"Tu nombre es {name} y tenes {age} años";
    }
}

