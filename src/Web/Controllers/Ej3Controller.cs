using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet("[action]")]
    public string GetSaludoEdad([FromQuery] string name, int age)
    {
        return $"Te llamas {name} y tinenes {age} amios.";
    }
}
