using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get()
        {
            List<int> nums = new List<int> { 7, 2, 30 };

            var Query = from num in nums
                        let pow = num * num
                        where pow > 20
                        select $"{num} - {pow}";

            return Ok(Query);
                        
        }
    }
}

/*
 5) Reciba una lista de números enteros y retorne una lista de sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20.
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”

 */
