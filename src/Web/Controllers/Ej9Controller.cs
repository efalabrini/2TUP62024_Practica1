using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<int>> Get(int inicio, int fin)
        {
            if (fin - inicio >= 200)
            {
                return BadRequest("La diferencia maxima entre INICIO y FIN es 200");
            } 

            List<int> nums = [];

            for (int n = inicio; n <= fin; n++)
            {
                if (n % 2 == 0)
                {
                    nums.Add(n);
                }
            }

            return Ok(nums);
        }
    }
}
