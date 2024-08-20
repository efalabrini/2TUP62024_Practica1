using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int start, int end)
    {
        List<int> oddNumbers = new List<int>();
        List<int> evenNumbers = new List<int>();

        if (Math.Abs(end - start) > 1000)
        {
            return BadRequest("La diferencia entre los números no puede ser mayor a 1000.");
        }

        if (start <= end)
        {
            int i = start;
            while (i <= end)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
                i++;
            }

        }
        else
        {
            int i = start;
            while (i >= end)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
                i--;
            }
        }

        return Ok(new { Pares = evenNumbers, Impares = oddNumbers });
    }
}