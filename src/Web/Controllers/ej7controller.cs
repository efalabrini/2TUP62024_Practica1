using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get(int inicio, int fin)
        {
            if (fin - inicio >= 1000)
            {
                return BadRequest("La diferencia es mayor a 1000");
            }

            var listnum = new List<int>();
            for (int i = inicio; i <= fin; i++)
            {
                listnum.Add(i);
            }

            return Ok(listnum);
        }
    }
}