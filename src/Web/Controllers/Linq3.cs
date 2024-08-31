using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linq3 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(){
            List<string> lista=["ventilador", "reloj", "buscador"];

            var retorno=lista.Where(x=>x.StartsWith("b") && x.EndsWith("r")).Select(x=>x);
            return Ok(retorno);
        }
    }
}
