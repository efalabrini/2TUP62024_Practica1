using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> palabra)
        {
            var respuesta = from string pal in palabra
                        where pal.Length >= 5
                        select pal.ToUpper();

            return respuesta.ToList();
        }

    }
}
