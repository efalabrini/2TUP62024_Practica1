using Microsoft.AspNetCore.Mvc;
using System.Linq;

[ApiController]
[Route("[controller]")]

public class Ej5Linq : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
        var result = (from number in numbers
                      let numberPow = Math.Pow(number, 2)
                      where numberPow > 20
                      select $"{number} - {numberPow}").ToList();

        return Ok(result);
    }
}