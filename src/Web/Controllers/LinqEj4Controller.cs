using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj4Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {
       var orderedNumbers = numbers.OrderBy(number => number).Reverse();
       var selectedNumbers = orderedNumbers.Where((number, index) => index < 5).ToList();

       return Ok(selectedNumbers);
    }
}