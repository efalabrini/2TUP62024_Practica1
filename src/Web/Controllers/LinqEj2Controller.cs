using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet("filter-words")]
        public IActionResult Get([FromQuery] List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return BadRequest("La lista de palabras no puede estar vacía.");
            }

            var filteredWords = words
                .Where(word => word.Length >= 5)
                .Select(word => word.ToUpper())
                .ToList();

            return Ok(filteredWords);
        }
    }
}

