using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return BadRequest("List can't be empty!");
            }

            var filteredWords = words
                .Select(n => n.ToLower().Replace("ia", "*"))
                .ToList();
            
            
            return Ok(filteredWords);
        }

    }
}
