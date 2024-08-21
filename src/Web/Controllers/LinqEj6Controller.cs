using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<string> words) {
            var wordsQuery = words.Select(x => x.Replace("ia", "*"));
            var result = wordsQuery.ToList();
            return Ok(result);
        }
    }
}
