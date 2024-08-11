using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4controller : ControllerBase
{

    [HttpGet]
    public int Get(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;  
        }
        else
        {
            return num2;   //si los dos son iguales da igual cual retorma
        }
    }
}
