//1) Reciba una lista de números enteros, un valor entero llamado min y un valor entero llamado max, 
//    y retorne una lista con los números mayores o iguales que min y menores o iguales que max.

using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers;



[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get(int min, int max, [FromQuery] List<int> numbers)
    {
        //lo que se guarda en la variable query es de tipo Ienumerable<T>
        var query = numbers.Where(num => num >= min && num <= max);
        var queryResult = query.ToList();

        //lo que hace el compilador cuando se usa var es deducir el tipo de dato de la variable segun el valor que se le da
        //osea si hacemos var x = 10 el compilador tratará a la var x entiende que x es de tipo int y de esa manera la tratara
        //osea si despues hacemos esto x = "hola" esto dará error ya que x es de tipo int

        if (max < min)
        {
            return BadRequest("El maximo no puedo ser menor al minimo");
        } 
        else if (numbers == null || numbers.Count() == 0)
        {
            return BadRequest("La lista de numeros se encuentra vacía");
        }
        else
        {
            return Ok(queryResult);
        }

    }
}
