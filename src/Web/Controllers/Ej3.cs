using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ejercicio3 : ControllerBase{

    [HttpGet]
    public string Get(string name, int age){
        return $"Te llamas {name}, tienes {age}";
    }
}
