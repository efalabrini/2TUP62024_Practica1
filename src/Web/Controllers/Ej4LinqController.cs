using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej4LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        List<int> numeros = new List<int>{12,10,11,13,14,0,2,5,-2};
        var Query = (from numero in numeros
            orderby numero descending
            select numero).Take(5);
            

        return Ok(Query);
    }
}


/*

4) Escriba una consulta que devuelva los 5 primeros números de la lista de enteros en orden descendente.
Ejemplo: [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21

*/