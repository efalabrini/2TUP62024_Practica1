using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj6Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<string> lista)
        { 
            var query = from word in lista
                        select word.Replace("ia", "*");

            return query.ToList();
        }
    }
}
