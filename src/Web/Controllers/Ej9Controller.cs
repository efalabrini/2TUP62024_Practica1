using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int start, int end)
    {
        int difference = end - start;
        if (difference > 1000)
        {
            return BadRequest($"Error: La diferencia entre start y end es mayor a 1000.");

        }
        // Generamos la lista 
        List<int> list = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (i % 2 ==0)
            {
            list.Add(i);
            }
        }
        return Ok(list);
    }
}
