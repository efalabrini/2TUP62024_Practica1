using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{

    [HttpGet]

     public int Get(int num)
    {
        num = 0;

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i); 
            num = i; 
        }

        return num; 
    }

}
