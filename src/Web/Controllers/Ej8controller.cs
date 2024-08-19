using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej8controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get(int start, int end)
    {
        int difference = end - start;
        List<int> numbers = new List<int>();
        int i = start;
        while(i <= end && difference < 1000) 
        {
            numbers.Add(i);
            i++;
        }
        if(numbers.Count > 0)
        {
            return Ok(numbers);
        } else
        {
            return BadRequest("La diferencia entre los dos números es mayor o igual a 1000");
        }
    }
}
