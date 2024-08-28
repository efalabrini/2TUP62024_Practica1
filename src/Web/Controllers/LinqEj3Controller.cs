/*3) Reciba una lista de palabras y retorne las que empiezan por la letra "b" y terminan con la letra "r".
Ejemplo: "ventilador", "reloj", "buscador" → "buscador"*/

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj3Controller : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> FilterWords([FromQuery] List<string> words)
        {
            var filteredWords = words
                .Where(word => word.StartsWith('b') && word.EndsWith('r'))
                .ToList();

            return Ok(filteredWords);
        }
    }
}

