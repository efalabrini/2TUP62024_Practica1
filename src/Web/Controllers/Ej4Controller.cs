//4) Reciba dos números y retorne el mayor.

using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public int Get(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;

        }else if (num2 > num1)
        {
            return num2;
        }
        else
        {
            return new int[] { num1, num2 };
        }
    }
}
