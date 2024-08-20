using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int start, int end)
    {
        List<int> numbers = new List<int>();

        if (Math.Abs(end - start) > 1000)
        {
            return BadRequest("La diferencia entre los números no puede ser mayor a 1000.");
        }

        if (start <= end)
        {
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
        }
        else
        {
            for (int i = start; i >= end; i--)
            {
                numbers.Add(i);
            }
        }

        return Ok(numbers);
    }
}
    
