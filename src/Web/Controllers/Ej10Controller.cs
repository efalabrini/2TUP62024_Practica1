using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int startNum, [FromQuery] int endNum)
        {
            if (endNum - startNum >= 1000)
            {
                return BadRequest("La diferencioa entre inicio y fin debe ser menor a 1000");
            }

            List<int> parList = new List<int>();
            List<int> inparList = new List<int>();

            while (startNum <= endNum)
            {
                if (startNum % 2 == 0)
                {
                    parList.Add(startNum);
                }
                else
                {
                    inparList.Add(startNum);
                }
                startNum++;
            }

            return Ok(new { parList, inparList});
        }
    }
}
}
