using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej3LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        List<string> palabras = new List<string>{"nacho","pep","cari","Ignacio","ventilador", "bucador", "busco"};
        var Query = from palabra in palabras
            where (palabra.StartsWith("b") && palabra.EndsWith("r"))
            select palabra.ToString();

        return Ok(Query);
    }
}



/*

3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
Ejemplo: "ventilador", "reloj", "buscador" → "buscador"

*/