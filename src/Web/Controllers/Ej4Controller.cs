using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{

    [HttpGet]
    public int Get(int numero1, int numero2)
    {
        if (numero1 > numero2)
        {
            return numero1;
        }
        else
        {
            return numero2;
        }
    }
}