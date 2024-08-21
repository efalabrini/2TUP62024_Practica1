using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<int> nums = new List<int>{123, 35, 67, -87, -39, 15};
            var Query = nums.OrderByDescending(num => num)
            .Take(5)
            .ToList();

            return Ok(Query);
        }

    }
}
