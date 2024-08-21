using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("La lista de números no puede estar vacía.");
            }

            var top5Descending = numbers
                .OrderByDescending(n => n)
                .Take(5)
                .ToList();

            return Ok(top5Descending);
        }
    }
}
