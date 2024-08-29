using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<string> palabras = new List<string> { "estudiar", "caminar", "dia" };
            var Query = from palabra in palabras
                        select palabra.Replace("ia", "*").ToString();
                        
            return Ok(Query);
        }

    }
}

/*
 6) Reciba una lista de palabras y  retorne una lista que sustituya la cadena 'ia' por el asterisco (*) en cada palabra dada. Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"
*/