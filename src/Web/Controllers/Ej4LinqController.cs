using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> lista)
        {
            var respuesta = (from int num in lista
                         orderby num descending
                         select num).Take(5);

            return respuesta.ToList();
        }

    }
}
