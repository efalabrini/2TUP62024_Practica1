using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet(Name = "action")]
        public ActionResult Get()
        {
            List<string> words = "Estudiar ESTUDIAR HoLa HOLA".Split(' ').ToList();

            var query =
                from word in words
                where word == word.ToUpper()
                select word;

            return Ok(query);
        }
    }

/* 
 * 7) Implementar la función public static IList<string> DevolverPalabrasCapitales(string cadena)
     que devuelva sólo las palabras en mayúsculas de la cadena.
     Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO
 */
}
