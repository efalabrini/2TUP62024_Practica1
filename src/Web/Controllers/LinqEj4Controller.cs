

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
        // numbers.Sort((x, y) => y.CompareTo(x));
        // return Ok(numbers);
        return Ok(numbers.OrderByDescending(n => n).Where((n, Index) => Index <= 4));
    }
}
