

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj6Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<String> numbers)
    {
        // numbers.Sort((x, y) => y.CompareTo(x));
        // return Ok(numbers);
        return Ok(numbers.Select(word => word.Replace("ia", "*" )));
    }
}