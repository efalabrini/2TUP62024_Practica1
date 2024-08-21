using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int start, int end)
    {
        int difference = end - start;
        if (difference > 1000)
        {
            return BadRequest($"Error: La diferencia entre start y end es mayor a 1000.");

        }
        List<int> list = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                list.Add(i);
            }
        }

        List<int> list2 = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 1)
            {
                list2.Add(i);
            }
        }
        return Ok(new { Pares = list, Impares = list2 });
       
    }
}
