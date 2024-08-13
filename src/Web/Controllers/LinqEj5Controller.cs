

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
        // numbers.Sort((x, y) => y.CompareTo(x));
        // return Ok(numbers);
        return Ok(numbers.Select(num => Math.Pow(num, 2)).Where(num => num>20));
    }
}