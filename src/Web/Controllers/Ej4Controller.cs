
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public string Get(int numero1, int numero2)
    {
        if (numero1 > numero2)
        {
            return $"{numero1}";
        }
        else if (numero1 < numero2)
        {
            return $"{numero2}";
        }
        else
        {
            return $"Los numeros son iguales: {numero1} ";
        }
    }
}
