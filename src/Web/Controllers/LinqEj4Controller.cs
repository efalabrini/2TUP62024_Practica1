using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<int>> Get([FromQuery] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("List of numbers can't be empty");
            }

            var filteredNumbers = numbers.Take(5)
                .OrderByDescending(x => x);
            return Ok(filteredNumbers);
        }
        
    }
}
