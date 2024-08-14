// Reciba dos números y retorne el mayor.
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class ej4Controller : ControllerBase
{
    [HttpGet]
    public int Get(int number1, int number2)
    {
        if (number1 > number2)
        {
            return number1;
        }
        else   
        {
            return number2;
        }
    }
}