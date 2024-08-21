using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<int> numbers, [FromQuery] int min, [FromQuery] int max)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("La lista de números no puede estar vacía.");
            }

            var filteredNumbers = numbers
                .Where(n => n >= min && n <= max)
                .ToList();

            return Ok(filteredNumbers);
        }
    }
}
