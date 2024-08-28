using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class Ej4LinqController : Controller
    {
        [HttpGet]

         public IActionResult Get([FromQuery]List<int> numbers) {
            var listQuery = numbers.OrderByDescending(x => x).Take(5).Select(x => x);
            var result = listQuery.ToList();
            
            return Ok(result);

        }
    }
}