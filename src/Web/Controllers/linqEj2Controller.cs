//2) Reciba una lista de palabras y retorne las de al menos 5 caracteres y las ponga en mayúsculas.
//Ejemplo: "computadora", "usb" → "COMPUTADORA"

using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;



[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] List<string> words)
    {
        if (words == null || words.Count() == 0)
        {
            return BadRequest("No se entregaron palabras para analizar");
        }
        else
        {
            var longWords = words.Where(word => word.Length >= 5);
            List<string> longWordsResult = longWords.Select(word => word.ToUpper().Trim()).ToList();
            return Ok(longWordsResult);
        }
    }
}