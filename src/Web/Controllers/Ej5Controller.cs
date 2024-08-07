using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{

    [HttpGet]
    public string Get(string nombreDia)
    {

        string diaFiltrado = nombreDia.Trim().ToLower();

        if (diaFiltrado == "lunes" || diaFiltrado == "martes" || diaFiltrado == "miercoles" || diaFiltrado == "jueves" || diaFiltrado == "viernes")
        {
            return "Es día de semana";
        }
        else if (diaFiltrado == "sabado" || diaFiltrado == "domingo")
        {
            return "Es fin de semana";
            
        }
        else
        {
            return "nombre no válido";
            
        }


       
    }
}

//5) Reciba el nombre del día y retorne si es fin de semana o no. En caso de error, debe retornar
//un status code del grupo de los 400 si es error del cliente o un status code del grupo de los 500 si es un error interno.
//Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” /        	“  lunes” y debería funcionar
