using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public string Get(string nombre, int edad)
    {
        return $"tu nombre es {nombre} y tenes {edad}";
    }
}
