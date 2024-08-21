using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Linq6Controller : Controller
    {
        [HttpGet]
        public IActionResult get([FromQuery]List<string> wordsList) { 
            var wordsQuery = wordsList.Select(x => x.ToLower().Replace("ia","*"));
            var result = wordsQuery.ToList();
            return Ok(result);
        }

    }
}
