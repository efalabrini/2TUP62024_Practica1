using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ej4controller : ControllerBase
{
    [HttpGet]
    public string Get(int num1, int num2)
    {
        if (num1 > num2)
        {
            return $"El numero {num1} es mayor";
        }
        else
        {
            return $"El numero {num2} es mayor";
        }
    }
}
