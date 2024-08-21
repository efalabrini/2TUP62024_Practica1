using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
/// <summary>
/// 10) Idem ejercicio 7, pero creando dos listas, 
/// una con los números pares y otra con los números impares.
/// Retornar las dos listas.
/// </summary>

[ApiController]
[Route("api/[controller]")]
    
    public class Ej10Controller : ControllerBase{
    
    [HttpGet]
    public IActionResult Get(int inicio, int fin)
    {
        if( (fin - inicio) > 1000 ){
            return BadRequest("La diferencia entre los numeros debe ser menor a 1000");
        }
        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();
        while (inicio <= fin)
        {
            if (inicio%2 ==0){
                numerosPares.Add(inicio);
            }else{
                numerosImpares.Add(inicio);
            }
            inicio++;
        }
        var listas = new{
            Pares = numerosPares,
            Impares = numerosImpares
        };
        return Ok(listas);
    }
}