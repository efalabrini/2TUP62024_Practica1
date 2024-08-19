using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get(int start, int end)
    {
        int difference = end - start;
        List<int> numbers = new List<int>();
        if (difference < 1000)
        {
            for (int i = start; i < difference; i++)
            {
                numbers.Add(i);
            }
            return Ok(numbers);
        } else
        {
            return BadRequest("La diferencia entre el número de fin y el de inicio es mayor a 1000");
        }

    }
}
