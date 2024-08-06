using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{


    [HttpGet]
    public string Get(string name, string nameCity)
    {
        return $"Hola  {name},  bienvenido a {nameCity}" ;
    }
}
