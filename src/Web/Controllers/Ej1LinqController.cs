using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej1LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        List<int> numbers = new List<int>{67,92,153,15, 45, 12, 55, 666};
        var Query = from num in numbers
            where (num > 30)
            select num.ToString();

        return Ok(Query);
    }

   /*
   
1) Dada una lista de números enteros, escriba una consulta que devuelva la lista de números mayores que 30 y menores que 100.
Ejemplo: [67, 92, 153, 15] → 67, 92

   */
}
