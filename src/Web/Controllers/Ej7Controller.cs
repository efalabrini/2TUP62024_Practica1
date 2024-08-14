using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int start, int end)
    {
        if(end - start >= 1000)
        {
            return BadRequest("La diferencia no puede ser menor a 1000");
        }

        List <int> listNumbers = new List<int>();

        for(var i = start; i<= end; i++)
        {
            listNumbers.Add(i);
        }

        return Ok(listNumbers);
    }
}