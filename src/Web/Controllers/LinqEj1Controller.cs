using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<int>> Get([FromQuery]List<int> numbers,[FromQuery] int min,[FromQuery] int max)
        {
            if(numbers == null || numbers.Count == 0) return BadRequest("the list cannot be empty");
            
            var numQuery = numbers.Where(x  => x >= min && x <= max).ToList();

            return Ok(numQuery);

        }
    }
}
