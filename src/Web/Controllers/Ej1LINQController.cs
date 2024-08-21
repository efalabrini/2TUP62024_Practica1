using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LINQController : ControllerBase
    {
        [HttpGet]
        public List<int> Get([FromQuery]List<int> list)
        {
            var filtrarLista = list.Where(x => x > 30 && 100 < x).ToList();
            return filtrarLista;
        }
    }
}
