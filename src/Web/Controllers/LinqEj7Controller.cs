/* 7) Reciba una cadena de texto y retorne una lista con las palabras que están completamente en mayúsculas.
Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO */

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj7Controller : Controller
    {
        [HttpGet]
        public ActionResult<List<string>> GetUpperCaseWords([FromQuery] string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return BadRequest("La cadena no puede estar vacía.");
            }

            var result = input
                .Split(' ')
                .Where(word => word.All(char.IsUpper))
                .ToList();
                
            return Ok(result);
        }
    }
}
