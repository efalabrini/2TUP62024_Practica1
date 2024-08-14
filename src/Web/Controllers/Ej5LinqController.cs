using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> lista)
        {
            var respuesta = from int n in lista
                        let cuadrado = n * n
                        where cuadrado > 20
                        select $"{n} - {cuadrado}";

            return respuesta.ToList();
        }

    }
}
