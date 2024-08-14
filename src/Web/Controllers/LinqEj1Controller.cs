using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int min, int max)
    {
        var listNums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        return Ok(listNums.Where(x => x >= min && x <= max).ToList());
    }
}

