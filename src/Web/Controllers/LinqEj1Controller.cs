using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int numMin, [FromQuery] int numMax, [FromQuery] List<int> numbers)
        {
            var numberList = numbers.Where(x => x >= numMin && x <= numMax).Select(x => x);
            var result = numberList.ToList();
            return Ok(result);
        }
    }
}
