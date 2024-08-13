
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]


public class LinqEj1Controller : ControllerBase {
    [HttpGet]

    public ActionResult Get(int min, int max) {
        var arrayNums = new List<int> {1,20,55,21,5,64,12,18,41};

        return Ok(arrayNums.Where(num => num >= min && num <= max));
    }
}