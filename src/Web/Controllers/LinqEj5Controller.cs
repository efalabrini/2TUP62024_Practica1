using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery]List<int> numbers)
        {
            var numQuery = (from num in numbers
                            let cuadrado = num * num
                            where cuadrado > 20
                            select $"{num} - {cuadrado}").ToList();
            return Ok(numQuery);
        }
    }
}
