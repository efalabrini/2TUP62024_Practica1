using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> palabras)
        {
            var respuesta = from string pal in palabras
                        select pal.Replace("ia", "*");

            return respuesta.ToList();
        }

    }
}
