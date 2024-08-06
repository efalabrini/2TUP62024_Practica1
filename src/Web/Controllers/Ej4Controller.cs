using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public string Get(int num1, int num2)
    {
        
        if (num1 > num2)
        return $"el número {num1} es mayor";
        else if (num2 > num1)
        return $"el número {num2} es mayor";
        else if (num1 == num2) 
        return "Los números son iguales";
        else
        return "error";
            
    }
}

//4) Reciba dos números y retorne el mayor.