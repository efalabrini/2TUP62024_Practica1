using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int start, int end)
    {
        // Verificar que la diferencia entre inicio y fin sea menor a 1000
        if (end - start >= 1000)
        {
            return BadRequest("La diferencia entre el número de inicio y fin debe ser menor a 1000.");
        }

        // Generar la lista de números desde start hasta end
        List<int> numbers = new List<int>();
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }

        return Ok(numbers);
    }
}

