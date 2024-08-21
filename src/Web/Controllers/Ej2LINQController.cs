using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LINQController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get([FromQuery] List<string> words)
        {
            var query = words.Where(w => w.Length >= 5).Select(w => w.ToUpper());
            return query;
        }
    }
}
