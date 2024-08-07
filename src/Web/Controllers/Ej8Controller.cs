using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej8Controller : ControllerBase
{

    [HttpGet]

    public int get(int num)
    {
        num=1;

        while(num<100)
        num++;

       return num;
    }

}