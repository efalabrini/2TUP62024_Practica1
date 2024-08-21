using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return BadRequest("list shold not be empty!");
            }

            var filteredWords = words
                .Where(word => word.StartsWith("v", StringComparison.OrdinalIgnoreCase) && word.EndsWith("r", StringComparison.OrdinalIgnoreCase))
                .ToList();

            return Ok(filteredWords);
        }

    }
}
