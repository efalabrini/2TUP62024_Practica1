using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return BadRequest("La cadena de texto no puede estar vacía.");
            }

            var result = text
                .Split(' ') 
                .Where(word => word.All(char.IsUpper))
                .ToList(); 

            return Ok(result);
        }
    }
}

