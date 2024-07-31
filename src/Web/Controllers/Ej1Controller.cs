using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet()]
        public int Get([FromQuery] int num1, [FromQuery] int num2, [FromQuery] int num3)
        {

            int result = num1 + num2 + num3;
            return result;
        }
    }
}
