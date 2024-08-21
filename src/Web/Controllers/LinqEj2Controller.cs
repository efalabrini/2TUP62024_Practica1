using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<string> words = new List<string>{"computadora", "usb", "fran", "Francesco"};
            var Query = from word in words
            where (word.Length >= 5)
            select word.ToUpper();

            return Ok(Query);
        }

    }
}
