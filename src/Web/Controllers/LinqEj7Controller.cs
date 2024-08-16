using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string sentence)
        {
            var sentenceQuery = sentence.Split(' ').Where(x => x.All(char.IsUpper)).Select(s => s).ToList();
            return Ok(sentenceQuery);
        }
    }
}
