using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Linq7Controller : Controller
    {
        [HttpGet]
        public IActionResult Get(string words)
        {
            var wordQuery = words.Split(' ').Where(x => x.All(char.IsUpper));
            var result = wordQuery.ToList();
            return Ok(result);
        }
    }
}
