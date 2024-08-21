using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
/// <summary>
/// 7) Reciba un número entero de inicio y un número entero de fin.
/// Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
/// Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
/// Usar un bucle for.
/// </summary>

[ApiController]
[Route("[controller]")]
public class Ej7controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get(int inicio, int fin)
    {
        if( (fin - inicio) > 1000 ){
            return BadRequest("La diferencia entre los numeros debe ser menor a 1000");
        }
        List<int> numeros = new List<int>();
        for (int i=inicio; i<=fin; i++){
            numeros.Add(i);
        }
        return Ok(numeros);
    }
}