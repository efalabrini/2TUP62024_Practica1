using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int start, int end)
    {
        //Me fijo que el inicio no sea mayor a 1000 o mayor al num final
        if (start > 1000 || start > end)
        {
            return BadRequest("El número de inicio no puede ser mayor a 1000 y tampoco mayor que el número final.");
        }

        
        if (end - start >= 1000)
        {
            return BadRequest("La diferencia entre el número de inicio y fin debe ser menor a 1000.");
        }
        
        List<int> parNumbers = new List<int>();
        List<int> imparNumbers = new List<int>();
        int current = start;

        while (current <= end)
        {
            if (current % 2 == 0)
            {
                parNumbers.Add(current);
            } else 
            {
                imparNumbers.Add(current);
            }
            current++;
        }

        return Ok(new
        {
            Pares = parNumbers,
            Impar = imparNumbers
        });
    }
}
