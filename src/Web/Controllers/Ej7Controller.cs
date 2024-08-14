//7) Reciba un número entero de inicio y un número entero de fin.
//Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
//Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
//Usar un bucle for.

using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int inicio, int final)
    {
        List<int> numeros = new List<int>();
        int diferencia = final - inicio;

        if (diferencia >= 1000)
        {
            return BadRequest("La diferencia entre ambos numeros debe ser menor a 1000");
        }
        else
        {
            for (int i = inicio; i <= final; i++)
            {
                numeros.Add(i);
            }
            return Ok(numeros);
        }
    }
}
