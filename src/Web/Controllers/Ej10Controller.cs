
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Web.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class Ej10Controller : ControllerBase
    {

        [HttpGet()]

        public IActionResult GetNumbersList(int start, int end)
        {
            if (Math.Abs(end - start) >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000");
            }

            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            for (int i = start; i <= end; i++) 
            {
                if ( i % 2 == 0)
                {  
                    evenNumbers.Add(i); 
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }

            var result = new
            {
                EvenNumbers = evenNumbers,
                OddNumbers = oddNumbers
            };

            return Ok(result);
        }

    }

}