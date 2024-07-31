using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ej1controller : ControllerBase
{

    [HttpGet]
    public int Get(int a, int b, int c)
    {
        int prueba = a + b + c;

        return prueba;
    }
}
