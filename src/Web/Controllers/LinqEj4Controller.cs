using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery]List<int> numbers)
        {
            var numQuery = numbers.OrderByDescending(x => x).Take(5).ToList();
            return Ok(numQuery);
        }
    }
}
