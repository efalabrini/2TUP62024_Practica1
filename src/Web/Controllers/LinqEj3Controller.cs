using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet("filter-words-b-r")]
        public IActionResult Get([FromQuery] List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return BadRequest("La lista de palabras no puede estar vacía.");
            }

            var filteredWords = words
                .Where(word => word.StartsWith("b") && word.EndsWith("r"))
                .ToList();

            return Ok(filteredWords);
        }
    }
}
