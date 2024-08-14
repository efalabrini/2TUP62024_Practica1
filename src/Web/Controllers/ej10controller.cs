using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get(int inicio, int fin)
        {
            if (fin - inicio > 1000)
            {
                return BadRequest("La diferencia es mayor o igual a 1000");
            }

            var listnum = new List<int>();
            var listnum3 = new List<int>();
            int i = inicio;
            while (i <= fin)
            {
                if (i % 2 == 0)
                {
                    listnum.Add(i);
                }
                else if (i % 2 == 1)
                {
                    listnum3.Add(i);
                }
                i++;
            }

            return Ok(new { Pares = listnum, impares = listnum3 });
        }
    }
}