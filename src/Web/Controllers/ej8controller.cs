using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get(int inicio, int fin)
        {
            if (fin - inicio > 1000)
            {
                return BadRequest("La diferencia es mayor o igual a 1000");
            }

            var listnum = new List<int>();
            int i = inicio;
            while (i <= fin)
            {
                listnum.Add(i);
                i++;
            }

            return Ok(listnum);
        }
    }
}