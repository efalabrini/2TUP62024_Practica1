using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Linq3Controller : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]List<string> words) {
            
            var listQuery = words.Where(x => x.StartsWith("b") && x.EndsWith("r")).Select(x => x);
            var result = listQuery.ToList();
            return Ok(result);
        }

    }
}
