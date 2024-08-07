using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class Ej1LinqController : Controller
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> lista)
        {
            var respuesta = from int n in lista
                        where n > 30 && n < 100
                        select n;

            return respuesta.ToList();
        }

    }
}
