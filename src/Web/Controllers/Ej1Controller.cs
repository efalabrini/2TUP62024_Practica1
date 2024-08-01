using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller: ControllerBase
{
    [HttpGet("[action]")]
    public string GetSuma([FromQuery]int number1, int number2, int number3)
    {
        int suma = number1 + number2 + number3;
        return "El resultado de la suma es: " + suma;
    }
}
