using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<string> words = new List<string>{"buscador", "baker", "fran", "Francesco", "brother"};
            var Query = from word in words
            where word.StartsWith("b") && word.EndsWith("r")
            select word;

            return Ok(Query);
        }

    }
}
