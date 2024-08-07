using Microsoft.AspNetCore.Mvc;

namespace Web;
[ApiController]
[Route("[controller]")]

public class Ej3Controller: ControllerBase 
{
    [HttpGet]
    public string Get(String name, int age) 
    {
        return $"Te llamas {name} y tenes {age}";
    }

}
