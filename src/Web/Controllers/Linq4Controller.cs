using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Linq4Controller : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery]List<int> numbers) {
            var listQuery = numbers.OrderByDescending(x => x).Take(5).Select(x => x);
            var result = listQuery.ToList();
            return Ok(result);

        }
    }
}
