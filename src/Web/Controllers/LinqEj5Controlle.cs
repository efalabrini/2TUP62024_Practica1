using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
        var result = numbers
           .Where(number => Math.Pow(number, 2) > 20)
           .Select(number => $"{number} - {Math.Pow(number, 2)}")
           .ToList();

        return Ok(result);
    }
}