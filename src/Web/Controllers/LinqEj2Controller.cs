// 2) Reciba una lista de palabras y retorne las de al menos 5 caracteres y las ponga en mayúsculas.
// Ejemplo: "computadora", "usb" → "COMPUTADORA"





using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{

    [HttpGet]
    public ActionResult Get()
    {
        
        var listWord = new List<string> {"computadora", "usb", "Reciba", "palabras", "las", "ponga"};
        
        
        var listWordUpper = listWord.Where(letter => letter.Length >= 5);


        return Ok(listWordUpper.Select(name => name.ToUpper()));

    }
}