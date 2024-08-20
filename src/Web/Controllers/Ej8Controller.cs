using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int start, int end)
        {
            int difference = end - start;
            if (difference > 1000)
            {
                return BadRequest($"Error: La diferencia entre start y end es mayor a 1000.");
            }

            // Generamos la lista usando un bucle while
            List<int> list = new List<int>();
            int current = start;

            while (current <= end)
            {
                list.Add(current);
                current++;
            }

            return Ok(list);
        }
}


 
    

