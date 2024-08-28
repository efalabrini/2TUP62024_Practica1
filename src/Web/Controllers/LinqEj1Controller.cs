using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

/* 
Reciba una lista de números enteros, un valor entero llamado min y un valor entero llamado max, y retorne una lista con los números mayores o iguales que min y menores o iguales que max.
*/
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(int minimo, int maximo, [FromQuery] List<int> numbers)
        {
            // filtramos la lista numbers y guardamos en la "lista" / IEnumerable query los que esten dentro del rango que pusimos
            var query = numbers.Where(num => num >= minimo && num <= maximo);
            // convertimos query en lista
            var queryResult = query.ToList();

            if (maximo < minimo)
            {
                return BadRequest("El maximo no debe ser mayor que el minimo");
            }
            else if (numbers == null || numbers.Count() == 0)
            {
                return BadRequest("LISTA VACIA");
            }
            else
            {
                return Ok(queryResult);
            }

        }
    }
}
