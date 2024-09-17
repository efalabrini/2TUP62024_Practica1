using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<int>> Get(int inicio, int fin)
        {
            if (fin - inicio >= 200)
            {
                return BadRequest("La diferencia maxima entre INICIO y FIN es 200");
            }

            List<int> pares = [];
            List<int> impares = [];

            for (int n = inicio; n <= fin; n++)
            {
                if (n % 2 == 0)
                {
                    pares.Add(n);

                } else
                {
                    impares.Add(n);
                }
            }
            return Ok(new{ pares, impares});

        }
    }
}
