using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej2LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        List<string> palabras = new List<string>{"nacho","pep","cari","Ignacio"};
        var Query = from palabra in palabras
            where (palabra.Length >= 5)
            select palabra.ToUpper();

        return Ok(Query);
    }
}

/*

2) Escriba una consulta que devuelva palabras de al menos 5 caracteres y las ponga en mayúsculas. 
Ejemplo: "computadora", "usb" → "COMPUTADORA"

*/