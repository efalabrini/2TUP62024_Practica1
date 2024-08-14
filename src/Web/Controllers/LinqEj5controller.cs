using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<int> numbers = [7, 2, 30];

        List<string> result = numbers.Select(x => $"{x} - {Math.Sqrt(x)}").ToList();

        return Ok(result);
    }
}
