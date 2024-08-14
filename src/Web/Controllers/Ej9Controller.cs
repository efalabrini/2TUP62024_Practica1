using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
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

        List<int> listNumbers = new List<int>();

        for (int number = start; number <= end; number++)
        {
            if (number % 2 == 0)
            {
                listNumbers.Add(number);
            }
        }

        return Ok(listNumbers);
    }
}