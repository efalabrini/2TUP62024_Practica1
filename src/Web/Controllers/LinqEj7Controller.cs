//7) Reciba una cadena de texto y retorne una lista con las palabras que están completamente en mayúsculas.
//Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO

using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj7Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get(string str)
    {
        List<string> Words = str.Split(" ").ToList();
        var UpperWords = Words.Where(word => word.All(char.IsUpper));

        //El método .All en LINQ se usa para verificar si todos los elementos de una secuencia cumplen con una condición 
        //específica.Es un método de extensión que se aplica a una colección de elementos y devuelve 
        //un valor booleano(true o false).

        return Ok(UpperWords);
    }
}