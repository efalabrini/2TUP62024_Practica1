using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] List<string> words) 
        { 
            var wordsQuery = words.Where(word => word.Length >= 5).Select(word => word.ToUpper());
            var result = wordsQuery.ToList();
            return Ok(result);
        }
    }
}
