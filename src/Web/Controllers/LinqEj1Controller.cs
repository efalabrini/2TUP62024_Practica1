using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    public static List<int> FilterNumbers(List<int> numbers)
    {
        var filteredNumbers = numbers.Where(n => n > 30 && n < 100).ToList();
        return filteredNumbers;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<int> numbers = [67, 92, 153, 15];

        List<int> result = FilterNumbers(numbers);

        return Ok(result);
    }
}
