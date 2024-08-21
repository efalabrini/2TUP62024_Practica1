using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LINQController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get([FromQuery] List<int> list)
        {
            var query = list.Select(x => (Num: x, Cuadrado: x * x)).Where(result => result.Cuadrado > 20).Select(result => $"{result.Num}-{result.Cuadrado}");

            return query;

        }
    }
}
