using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web
{
    [Route("[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<string> list)
        {
            var wordList =
                from word in list
                select word.Replace("ia", "*");

            return wordList.ToList();
        }
    }
}