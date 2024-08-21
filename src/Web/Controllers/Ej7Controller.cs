using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]

        public IActionResult GenerateList([FromQuery] int start, [FromQuery] int end)  
        {
            // Verificación de si la diferencia entre fin e inicio es menor a 1000
            if (Math.Abs(end - start) < 1000)
            {
                List<int> numbers = GenerateListNumbers(start, end);
                return Ok(numbers);
            }
            else
            {
                return BadRequest("La diferencia entre los números de inicio y fin es mayor o igual a 1000.");
            }
        }

        private List<int> GenerateListNumbers(int start, int end)  // metodo que genera y retorna una lista de enteros de num inicio a num fin.
        {
            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++) // For pedido para armar la lista de numeros a retornar
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
       

    

