using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public int Get(int num_1, int num_2)
    {
        int major_num = num_1 > num_2 ? num_1 : num_2;
        return major_num;
    }
}