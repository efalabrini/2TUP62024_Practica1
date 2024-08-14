using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int start, int end)
    {
        if (start > end)
        {
            return BadRequest("El primer número NO puede ser mayor que el segundo");
        }

        if (end - start >= 1000)
        {
            return BadRequest("La diferencia no puede ser mayor que 1000");
        }

        List<int> parNumbers = new List<int>();
         List<int> imparNumbers = new List<int>();

        for(int number = start; number <= end; number++)
        {
            if(number % 2 == 0)
            {
                parNumbers.Add(number);
            }
            else
            {
                imparNumbers.Add(number);
            }
        }

        return Ok(new{
            par = parNumbers,
            impar = imparNumbers
        });
    }
}