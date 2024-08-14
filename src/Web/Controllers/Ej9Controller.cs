//Reciba un número entero de inicio y un número entero de fin.
//Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
//Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
//pero retornando solo los números pares. Usar el bucle que le resulte más conveniente.



using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int inicio, int final)
    {
        //inicializo una lista que es como un array pero que tiene metodos propios y ademas es dinamico :)
        List<int> numeros = new List<int>();
        int diferencia = final - inicio;

        if (diferencia >= 1000)
        {
            return BadRequest("La diferencia entre ambos numeros debe ser menor a 1000");
        }
        else
        {
            int i = inicio;
            while (true)
            {

                if (i % 2 == 0)
                {
                    numeros.Add(i);
                }

                i = i + 1;
                if (i > final)
                {
                    break;
                }
            }
            return Ok(numeros);
        }
    }
}