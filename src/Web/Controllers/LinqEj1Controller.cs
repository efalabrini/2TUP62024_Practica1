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
            List<int> numbers = new List<int>{67,92,153,15, 45, 12, 55, 666};

            var Query = from num in numbers
            where (num > 30)
            select num.ToString();
            
            return Ok(Query);
        }

    }
}
