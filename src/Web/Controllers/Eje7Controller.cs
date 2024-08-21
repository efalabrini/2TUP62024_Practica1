using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Eje7Controller : Controller
    {
        [HttpGet]
        public ActionResult StartEnd(int numStart, int numEnd)
        {
            List<int> numStartEnd = [];
            if (numStart > numEnd)
            {
               return BadRequest("El número de inicio no puede ser mas grande que el número de fin");
            }
            else 
            {
                if (numEnd - numStart > 1000)
                {
                    return BadRequest("La diferencia de los números debe ser menor o igual a mil");
                }
                else 
                {
                    
                    for (int i = numStart;  i <= numEnd;  i++)
                    {
                        numStartEnd.Add(i);
                    }
                }
            }
            return Ok(numStartEnd);
        }
    }
}
