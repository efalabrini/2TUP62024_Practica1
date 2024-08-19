//3) Reciba una lista de palabras y retorne las que empiezan por la letra "b" y terminan con la letra "r".
//Ejemplo: "ventilador", "reloj", "buscador" → "buscador"

using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] List<string> words)
    {

        if (words == null || words.Count == 0)
        {
            return BadRequest("No se ingresó ninguna palabra");
        }
        else
        {
            var selectedWords = words.Where(word => word.ToLower().Trim()[0] == 'b' && word.ToLower().Trim()[word.Length - 1] == 'r');
            List<string> selectedWordsResult = selectedWords.ToList();
            return Ok(new { message = "Las palabras que pasaron la condicion son: ", words = selectedWordsResult });
        }
    }
}
