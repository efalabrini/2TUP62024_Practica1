using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return BadRequest("La lista de palabras no puede estar vacía.");
            }

            var result = words
                .Select(word => word.Replace("ia", "*"))
                .ToList();

            return Ok(result);
        }
    }
}
