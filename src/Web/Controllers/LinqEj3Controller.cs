using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<string> words)
        {
            var wordsQuery = words.Where(x => x.ToLower().StartsWith('b') && x.EndsWith('r')).ToList();
            return Ok(wordsQuery);
        }
    }
}
