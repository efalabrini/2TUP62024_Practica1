using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class EjLinq7 : ControllerBase
{
    
    public static IList<string> DevolverPalabrasCapitales(string cadena)
    {
        var wordQuery = from word in cadena.Split(' ')
                        where word.All(char.IsUpper)
                        select word;


        return wordQuery.ToList();
    }

    [HttpGet]
    public ActionResult Get(string cadena)
    {

        var wordQuery = DevolverPalabrasCapitales(cadena);


        return Ok(wordQuery);
    }
}


