using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<int> numbers = new List<int> {67,92,153,15,45,12,55};

            var Query =
                from num in numbers
                where num > 30 && num < 100
                select num;

            return Ok(Query);
        }

    }
}
