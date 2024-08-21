using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult Get([FromQuery] List<int> numbers, int min, int max)
        {
            if (min > max)
            {
                return BadRequest("min number should not be higher than max!");
            }

            var filteredNumbers = numbers.Where(n => n >= min && n <= max).ToList();

            return Ok(filteredNumbers);
        }
    }
}
