using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Linq5Controller : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<int> numbers) {
            var listQuery = numbers.Where(x => x*x > 20).Select(x => ($"{x} - {x*x}"));
            var result = listQuery.ToList();
            return Ok(result);

        }
    }
}
