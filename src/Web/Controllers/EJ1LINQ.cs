using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EJ1LINQ : ControllerBase
    {

        [HttpGet]

        public IActionResult getnumers()
        {
            List<int> numeros = [15, 25, 40, 50, 60, 101, 102];
            var resultado = numeros.Where(x => x > 30 && x < 100).Select(x => x);
            return Ok(resultado);
        }
    }
}
