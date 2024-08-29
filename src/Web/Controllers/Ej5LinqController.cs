using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej5LinqController : Controller
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<int> numList)
        {
            var query = (from num in numList
                         let numCuadrado = num * num
                         where numCuadrado > 20
                         select $"{num} - {numCuadrado}").ToList();

           return query;
        }
    }
}

//5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato:
//"número - cuadrado" sólo si el cuadrado es mayor que 20
//Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”

