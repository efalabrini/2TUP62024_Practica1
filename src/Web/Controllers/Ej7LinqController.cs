using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7LinqController : ControllerBase
    {
        [HttpGet()]
        public IList<string> Get([FromQuery] string palabras)
        {
            return DevolverPalabrasCapitales(palabras);
        }
        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            var cadenaSplit = cadena.Split(" ");

            var respuesta = from pal in cadenaSplit
                            where pal == (pal.ToUpper())
                            select pal;


            return respuesta.ToList();
        }
    }
}
}
