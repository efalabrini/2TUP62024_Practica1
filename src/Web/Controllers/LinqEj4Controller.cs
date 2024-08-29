using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet("[action]")]
        
        public ActionResult Get()
        {
            List<int> nums = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };
            var Query = (from num in nums
                        orderby num descending
                        select num).Take(5);
            return Ok(Query);
        }

    }
}

/*4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21
*/