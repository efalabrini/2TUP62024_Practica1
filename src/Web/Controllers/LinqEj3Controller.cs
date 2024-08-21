using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<string> words)
        {
            var wordsQuery = from w in words
                             where w.StartsWith("b") && w.EndsWith("r")
                             select w;
            var result = wordsQuery.ToList();
            return Ok(result);
        }
    }
}
