using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Eje1LinqController : Controller
    {
        [HttpGet]
        public ActionResult minMaxList([FromQuery]List<int>  numList, int min, int max)
        {
           var minMaxList = numList.Where(x => x >= min && x <= max).Select(x => x);
            var result = minMaxList.ToList();

            return Ok(result);
        }
    }
}
