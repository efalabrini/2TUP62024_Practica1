using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery] string words)
        {
            if (words == null || words.Length == 0)
            {
                return BadRequest("Please make sure to write something!");
            }

            var filteredWords = words.Split(' ')
                .Where(words => words == words.ToUpper());
            
            return Ok(filteredWords);


        }
        //            7) Reciba una cadena de texto y retorne una lista con las palabras que están completamente en mayúsculas.
        //Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO

    }
}
