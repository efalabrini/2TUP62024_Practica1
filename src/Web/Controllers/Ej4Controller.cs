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
            {
                return $"El número mayor es: {num1}";
            }
            else if (num1 < num2)
            {
                return $"El número mayor es: {num2}";
            }
            else
            {
                return "Los números son iguales";
            }
    }
}
