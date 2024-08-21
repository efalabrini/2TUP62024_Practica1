using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj1Controller : Controller
    {
        [HttpGet]
        public ActionResult minMaxList([FromQuery] List<int> numList, int min, int max)
        {
            var minMaxList = numList.Where(x => x >= min && x <= max).ToList();

            return Ok(minMaxList);
        }
    }
}
