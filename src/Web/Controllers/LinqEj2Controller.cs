using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery]List<string> words)
        {
            if(words == null || words.Count == 0) return BadRequest("the list cannot be empty");
            
            var wordsQuery = words.Where(x => x.Length  >= 5).Select(w => w.ToUpper()).ToList();
            return Ok(wordsQuery);
        }
    }
}
