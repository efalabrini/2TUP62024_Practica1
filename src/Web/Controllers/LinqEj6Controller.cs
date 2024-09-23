using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet]

        public ActionResult Get([FromQuery] List<string> wordsIa)
        {
            var words =
                from word in wordsIa
                where word.Contains("ia")
                select word.Replace("ia","*");
            return Ok(words);
        }
    }

