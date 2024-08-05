using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery] string name, [FromQuery] int age)
        {
            return $"Te llamas ” {name} ” y tienes ” {age} ” años”";
        }
    }
}
