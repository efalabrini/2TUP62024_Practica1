using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej8Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int start, int end)
    {
        if(start > end)
        {
            return BadRequest("El primer número NO puede ser mayor que el segundo");
        }

        if(end - start >= 1000)
        {
            return BadRequest("La diferencia no puede ser mayor que 1000");
        }

        List <int> listNumbers = new List <int>();

        int number = start;

        while(number <= end)
        {
            listNumbers.Add(number);
            number++;
        }

        return Ok(listNumbers);
    }
}    