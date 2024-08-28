using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Web.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]

        public IActionResult GenerateList([FromQuery] int start, [FromQuery] int end)
        {
            //Verificacion de si la diferencia entre fin e inicio es menor a 1000
            if (Math.Abs(end - start) < 1000)
            {
                List<int> numbers = GenerateListNumbers(start, end);
                return Ok(numbers);
            }
            else
            {
                return BadRequest("La diferencia entre los numeros de inicio y fin es mayor o igual a 1000");
            }
        }

        private List<int> GenerateListNumbers(int start, int end)
        {
            List<int> numbers = new List<int>();

            int i = start; // Inicializo i con el valor inicial
            
            while (i <= end)  // While pedido para generar la lista de num
            {
                numbers.Add(i);
                i++;
            }
            return numbers;
            
        }

        
    }
}
