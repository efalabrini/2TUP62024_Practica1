/* 6) Reciba una lista de palabras y  retorne una lista que sustituya la cadena 'ia' por el asterisco (*) en cada palabra dada. 
Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*" */ 


using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj6Controller : Controller
    {
        [HttpGet]
        public ActionResult<List<string>> ReplaceSubstring([FromQuery] List<string> words)
        {
            if (words == null || !words.Any())
            {
                return BadRequest("La lista no puede estar vacía.");
            }

            var result = words
                .Select(word => word.ToLower().Replace("ia", "*"))
                .ToList();

            return Ok(result);
        }
    }
}