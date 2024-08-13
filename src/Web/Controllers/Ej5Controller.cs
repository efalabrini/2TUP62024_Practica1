//5) Reciba el nombre del día y retorne si es fin de semana o no. En caso de error,
//debe retornar un status code del grupo de los 400 si es error del cliente
//o un status code del grupo de los 500 si es un error interno.
//Se debe poder ingresar, por ejemplo, “Lunes” / “LUNES” / “lunes” / “lUnes” / 	“  lunes” y debería funcionar

using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
   
    [HttpGet]
    public IActionResult Get(string dia)
    {
        //al dia que recibo lo le elimino los espacios con trim y lo convierto todo a minusculas con ToLower
        dia = dia.ToLower().Trim();
        string[] diasSemana = { "lunes", "martes", "miercoles", "jueves", "viernes" };
        string[] finDeSemana = { "sabado", "domingo" };
        
        //array.existe verifica si algo existe dentro de un array. Primero se le pasa que array debe recorrer primero
        //luego se le pasa el nombre que recibirá cada elemento del array en cada iteracion en este caso "d"
        //y luego viene la condicion, en este caso es que coincidan algunos de los strings con el dia pasado por parametro
        if (Array.Exists(diasSemana,d => d == dia))
        {
            //se retorna un Ok que devuelve un status code de 200 lo que quiere decir que todo salio bien
            return Ok("Es dia de semana");
        }
        else if (Array.Exists(finDeSemana,d => d == dia))
        {
            return Ok("Es fin de semana");
        }
        else
        {
            //en caso de no cumplirse ninguna de las condiciones se devuelve un badRequest el cual indica que tipo de error
            //hubo y ademas imprime el mensaje indicado
            //Retorna una respuesta HTTP con el código de estado 400 (Bad Request) solo sirve para errores de tipo 400)
            //este método se usa para indicar que hubo un error relacionado con la solicitud del cliente,como datos inválidos.
            return BadRequest("Se Ingreso una opcion no valida");
        }
    }
}
