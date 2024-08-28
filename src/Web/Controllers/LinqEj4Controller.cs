/* 4) Reciba una lista de números enteros y retorne una lista con los 5 primeros que corresponden a la lista ingresada ordenada 
en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21 */

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj4Controller : Controller
    {
        [HttpGet]
        public ActionResult<List<int>> GetTopFive([FromQuery] List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return BadRequest("La lista no puede estar vacía.");
            }

            var topFive = numbers.OrderByDescending(n => n).Take(5).ToList();

            return Ok(topFive);
        }
    }
}