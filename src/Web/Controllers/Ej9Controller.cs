using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
//9) Idem ejercicio 7, pero retornando solo los números pares. 
//Usar el bucle que le resulte más conveniente.(WHILE)

[ApiController]
[Route("api/[controller]")]
    
    public class Ejercicio9 : ControllerBase{
    
    [HttpGet]
    public IActionResult Get(int inicio, int fin)
    {
        if( (fin - inicio) > 1000 ){
            return BadRequest("La diferencia entre los numeros debe ser menor a 1000");
        }
        List<int> numeros = new List<int>();
        while (inicio <= fin)
        {
            if (inicio%2 ==0){
                numeros.Add(inicio);
            }
            inicio++;
        }
        return Ok(numeros);
    }

}
