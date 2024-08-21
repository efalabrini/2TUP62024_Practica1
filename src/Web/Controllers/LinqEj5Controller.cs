using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<int> numbers) { 
            var numbersQuery = numbers.Where(x => x*x > 20 ).Select(x => x.ToString($"{x} - {x*x}"));
            var result = numbersQuery.ToList();
            return Ok(result);
        }
    }
}
