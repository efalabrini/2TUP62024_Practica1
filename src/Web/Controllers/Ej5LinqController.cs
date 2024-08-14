using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej5LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        List<int> numeros = new List<int>{12,10,11,13,14,0,2,5,-2};
        var Query = from numero in numeros
            let cuadrado = numero * numero
            where cuadrado > 20
            select $"{numero} - {cuadrado}";
            

        return Ok(Query);
    }
}


/*

5) Escriba una consulta que devuelva una lista de números y sus cuadrados en formato: "número - cuadrado" sólo si el cuadrado es mayor que 20
Ejemplo: [7, 2, 30] → “7 - 49”, “30 - 900”

*/