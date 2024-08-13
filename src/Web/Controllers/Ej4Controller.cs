/*4) Pedir dos números al usuario por teclado y decir qué número es el mayor.*/

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
            return $"El numero {num1} es mayor a {num2}";
        }
        else
        {
            return $"El numero {num2} es mayor a {num1}";
        }
    }
}

