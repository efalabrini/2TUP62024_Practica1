using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public int Get(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }
}
