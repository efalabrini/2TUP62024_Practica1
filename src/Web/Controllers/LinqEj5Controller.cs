using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet]

        public List<string> Get([FromQuery] List<int> lista)
        {
            var query = from int l in lista
                        let cuadrado = l * l
                        where cuadrado > 20

                        select $"{l} - {cuadrado}";

              return query.ToList();
        }
    }
}
