using Microsoft.AspNetCore.Mvc;

namespace Web;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> lista)
    {
        var filterList = from word in lista
                         where word.Length >= 5
                         select word.ToUpper();
        return Ok( filterList.ToList());
        
    }
}

//2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas.
//Ejemplo: "computadora", "usb" → "COMPUTADORA"
