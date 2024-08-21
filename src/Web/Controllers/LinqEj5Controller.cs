using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<int>> Get([FromQuery] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return BadRequest("Please make sure the list of numbers is not empty");
            }

            var filteredNumbers = numbers
             .Select(number => new
             {
                 Number = number,
                 Square = number * number
             })
             .Where(result => result.Square > 20)
             .Select(result => $"{result.Number} - {result.Square}")
             .ToList();

            return Ok(filteredNumbers);

            //var filteredNumbers = numbers
            //    .Select(x => x * x)
            //    .Where(n => n > 20)
            //    .ToList();
            //return Ok(filteredNumbers);


        }
    }
}
