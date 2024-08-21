using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
//8) Idem ejercicio 7 pero usando un bucle while

[ApiController]
[Route("api/[controller]")]
    
    public class Ejercicio8 : ControllerBase{
    
    [HttpGet]
    public IActionResult Get(int inicio, int fin)
    {
        if( (fin - inicio) > 1000 ){
            return BadRequest("La diferencia entre los numeros debe ser menor a 1000");
        }
        List<int> numeros = new List<int>();
        while (inicio <= fin)
        {
            numeros.Add(inicio);
            inicio++;
        }
        return Ok(numeros);
    }

}

