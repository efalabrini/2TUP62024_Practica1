using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<int> numbers) {
            var numbersQuery = numbers.OrderByDescending(x => x).Take(5).Select(x => x);
            var result = numbersQuery.ToList();
            return Ok(result);
        }
    }
}
