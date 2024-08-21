using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LINQController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> Get([FromQuery] List<int> list)
        {
            var query = list.OrderByDescending(n => n);
            return query;
        }
    }
}
