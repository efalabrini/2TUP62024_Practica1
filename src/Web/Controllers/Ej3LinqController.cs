using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> palabras)
        {
            var respuesta = from string pal in palabras
                        where pal[0].ToString() == "b" && pal.EndsWith('r')
                        select pal;

            return respuesta.ToList();
        }

    }
}
