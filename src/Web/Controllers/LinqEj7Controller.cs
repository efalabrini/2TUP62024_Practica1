using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            return Ok(DevolverPalabrasCapitales("ESTO es un EJEMPLO de EJercicio"));
        }

        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            string[] palabras = cadena.Split(" ");
            var Query = from palabra in palabras
                        where palabra == palabra.ToUpper()
                        select palabra;

            return Query.ToList();
        }

    }
}
