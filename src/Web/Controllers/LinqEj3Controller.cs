using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<string> words = new List<string> { "ventilado", "reloj", "buscador", "brabor"};
            var Query = from word in words
                        where word.StartsWith("b") && word.EndsWith("r")
                        select word.ToString();
            return Ok(Query);
        }
    }
}


/*
3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
Ejemplo: "ventilador", "reloj", "buscador" → "buscador"
*/
