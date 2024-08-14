using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej6LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        List<string> palabras = new List<string>{"dia","nacho","cofradia","Guaracha"};
        var Query = from palabra in palabras
            select palabra.Replace("ia","*");
            

        return Ok(Query);
    }
}


/*

6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"

*/