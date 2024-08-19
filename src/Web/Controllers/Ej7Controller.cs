using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int startNum,[FromQuery] int endNum)
        {
        
            if (endNum - startNum >= 1000)
            {
                return BadRequest("La diferencia entre el numero de inicio y el de fin debe ser menor a 1000");
            }
           
            List<int> numberList = new List<int>();

        
            for (int i = startNum; i <= endNum; i++)
            {
                numberList.Add(i);
            }

            return Ok(numberList);
        }
    }
}
