using Microsoft.AspNetCore.Mvc;

namespace Web;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get([FromQuery] List<string> listaPalabras)
    {
        var query = from string p in listaPalabras
                    let lowerP = p.ToLower()
                    where lowerP.StartsWith("b") && lowerP.EndsWith("r")
                    select p;

        return query.ToList();

    }
}

//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
//Ejemplo: "ventilador", "reloj", "buscador" → "buscador"
