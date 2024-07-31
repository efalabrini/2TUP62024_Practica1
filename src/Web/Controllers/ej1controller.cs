using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ej1controller : ControllerBase
{




    public ej1controller()
    {

    }

    [HttpGet]
    public int Get([FromQuery] int a, [FromQuery] int b, [FromQuery] int c)
    {
        int prueba = a + b + c;

        return prueba;
    }
}
