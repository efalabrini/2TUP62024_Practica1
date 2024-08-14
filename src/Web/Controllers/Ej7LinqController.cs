
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej7LinqController : ControllerBase
{
    [HttpGet("[action]")]
    public ActionResult Get(){
        return Ok(DevolverPalabrasCapitales("ESTO es un EJEMPLO de EJercicio"));
    }

    public static IList<string> DevolverPalabrasCapitales(string cadena)
    {
        string[] palabras = cadena.Split(" ");
        var Query = from palabra in palabras
                    where palabra == palabra.ToUpper()
                    select palabra;

        return Query.ToList();
    }
}



/*

7) Implementar la función 

public static IList<string> DevolverPalabrasCapitales(string cadena)

que devuelva sólo las palabras en mayúsculas de la cadena.
Ejemplo: "ESTO es un EJEMPLO del EJERcicio" → ESTO, EJEMPLO

*/