using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ej4controller : ControllerBase
{
    [HttpGet]
    public string Get(int num1, int num2)
    {
        if(num1 > num2){
            return $"{num1} es mayor que {num2}";
        }else if(num1 == num2){
            return $"Los numeros son iguales";
        }else{
            return $"{num2} es mayor que {num1}";
        }
    }
}