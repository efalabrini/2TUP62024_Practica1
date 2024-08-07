using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int num1, int num2)
        {
            int mayor;

            if (num1 > num2)
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }

            return Ok(mayor);
        }
    }
}