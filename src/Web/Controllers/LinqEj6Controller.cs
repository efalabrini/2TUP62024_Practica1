using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<string> words)
        {
            var wordsQuery = from word in words
                             select word.Replace("ia", "*");

            return Ok(wordsQuery);
        }
    }
}
