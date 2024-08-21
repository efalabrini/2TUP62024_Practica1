using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("La lista de números no puede estar vacía.");
            }

            var result = numbers
                .Where(n => n * n > 20) 
                .Select(n => $"{n} - {n * n}") 
                .ToList(); 

            return Ok(result);
        }
    }
}
