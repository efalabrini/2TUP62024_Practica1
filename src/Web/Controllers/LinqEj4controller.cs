using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj4controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<int> numbers = [78, -9, 0, 23, 54, 21, 7, 86];

        List<int> result = numbers.OrderByDescending(x => x).Take(5).ToList();

        return Ok(result);
    }
}
