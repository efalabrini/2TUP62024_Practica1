/* 2) Reciba una lista de palabras y retorne las de al menos 5 caracteres y las ponga en mayúsculas.
Ejemplo: "computadora", "usb" → "COMPUTADORA"*/

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqEj2Controller : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> FilterAndUppercase([FromQuery] List<string> words)
        {
            var filteredWords = words
                .Where(word => word.Length >= 5)
                .Select(word => word.ToUpper())
                .ToList();

            return Ok(filteredWords);
        }
    }
}
