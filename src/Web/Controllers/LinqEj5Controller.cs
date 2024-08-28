/* 5) Reciba una lista de números enteros y retorne una lista de sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado
es mayor que 20.
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900” */

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj5Controller : Controller
    {
        [HttpGet]
        public ActionResult<List<string>> GetSquares([FromQuery] List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return BadRequest("La lista no puede estar vacía.");
            }

            var result = numbers
                .Select(n => new { Number = n, Square = n * n })
                .Where(x => x.Square > 20)
                .Select(x => $"{x.Number} - {x.Square}")
                .ToList();

            return Ok(result);
        }
    }
}



