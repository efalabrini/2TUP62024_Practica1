using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] List<string> words)
        {
            var query =
                from w in words
                where w.Length > 4
                select w.ToUpper();

            return query.ToArray();
        }
    }
}

/*
 Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
 Ejemplo: "computadora", "usb" → "COMPUTADORA"
*/