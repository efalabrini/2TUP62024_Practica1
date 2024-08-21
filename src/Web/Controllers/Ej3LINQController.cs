using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LINQController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get([FromQuery] List<string> word)
        {
            var query = word.Where(w => w.StartsWith("b") && w.EndsWith("r"));
            return query;
        }
    }
}
