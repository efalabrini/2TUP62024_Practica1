using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Linq6 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(){
            List <string> palabras=["estudiar", "caminar", "dia"];
            var retorno=palabras.Select(x=>x.Replace("ia","*"));
            return Ok(retorno);
        }
    }
}
