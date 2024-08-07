using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4controller : ControllerBase
{
    [HttpGet]
    public string Get(int uno, int dos)
    {
        if (uno > dos)
        {
            return $"El primer número ({uno}) es mayor que el segundo número ({dos}).";
        }
        else if (dos > uno)
        {
            return $"El segundo número ({dos}) es mayor que el primer número ({uno}).";
        }
        else
        {
            return "Ambos números son iguales.";
        }
    }
}

