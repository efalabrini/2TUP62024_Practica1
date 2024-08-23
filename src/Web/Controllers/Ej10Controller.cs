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
            return BadRequest("La diferencia es mayor a 1000");

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
        return Ok(new { Numeros pares = list, Numeros impares = list2 });

    }
}