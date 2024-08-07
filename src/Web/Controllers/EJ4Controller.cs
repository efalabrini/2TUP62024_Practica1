using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class EJ4Controller: ControllerBase
{
    [HttpGet]

    public string Get(int numero1, int numero2)
    {
        if (numero1 > numero2)
        {
            return $"{numero1} es mayor que {numero2}";
        }
        else if (numero1 < numero2)
        {
            return $"{numero2} es mayor que {numero1}";
        }
        else
        {
            return $"{numero1} es igual a {numero2}";
        }
    }

}
