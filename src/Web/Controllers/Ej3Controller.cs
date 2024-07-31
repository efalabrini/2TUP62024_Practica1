using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpGet]
        public string Get(string name, int age)
        {
            return $"Te llamas {name} y tenes {age} años";
        }
    }
}
