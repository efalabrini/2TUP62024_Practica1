using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string sentence)
        {
            var sentenceQuery = sentence.Split(' ').Where(word => word.All(char.IsUpper));
            var result = sentenceQuery.ToList();
            return Ok(result);
        }
    }
}
