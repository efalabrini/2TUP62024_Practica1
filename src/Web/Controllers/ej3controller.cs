using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ej3controller : ControllerBase
{
    [HttpGet]
    public string Get(string nombre, string edad)
    {
        return $"Te llamas {nombre}  y tienes  {edad}  años";
    }
}
