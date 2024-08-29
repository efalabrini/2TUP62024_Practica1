using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Get() 
        {
            List<string> words = new List<string> { "computador", "usb", "practica", "hola"};
            var Query = from word in words
                        where (word.Length >= 5)
                        select word.ToUpper();

            return Ok(Query);
        }
    }
}

/*
2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
Ejemplo: "computadora", "usb" → "COMPUTADORA"
*/
