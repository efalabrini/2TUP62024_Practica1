using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

/*  
Reciba una lista de palabras y retorne las de al menos 5 caracteres y las ponga en mayúsculas.
Ejemplo: "computadora", "usb" → "COMPUTADORA"
*/

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] List<string> palabra)
    {
        // Verifica si la lista es nula o está vacía y retorna un error BadRequest con un mensaje
        if (palabra == null || palabra.Count() == 0)
        {
            return BadRequest("No hay palabras");
        }
        else
        {
            // filtra las palabras que tienen al menos 5 caracteres
            var longWords = palabra.Where(word => word.Length >= 5);

            // Convierte las palabras filtradas a mayusculas y elimina espacios en blanco al principio y al final
            // las convierte en una lista
            List<string> longWordsResult = longWords.Select(word => word.ToUpper().Trim()).ToList();

            return Ok(longWordsResult);
        }
    }
}
