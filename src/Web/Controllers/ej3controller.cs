using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ej3controller : ControllerBase
{
    [HttpGet]
    public string Get(string name, int age)
    {
        return $"Te llamas {name} y tenes {age}";
    }
}