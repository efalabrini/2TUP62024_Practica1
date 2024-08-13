// 3) Reciba una lista de palabras y retorne las que empiezan por la letra "b" y terminan con la letra "r".
// Ejemplo: "ventilador", "reloj", "buscador" → "buscador"


using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        
        var listWord = new List<string> {"ventilador", "reloj", "BuscadoR", "baR"};
        
        
       


        return Ok(listWord.Where(letter => letter.ToLower().StartsWith("b") && letter.ToLower().EndsWith("r")));

    }
}