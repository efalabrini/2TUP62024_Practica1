using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4Controller : Controller
    {
        [HttpGet]
        public ActionResult Get(int num1, int num2) {
            if (num1 == num2)
            {
                return Ok("Los numeros son iguales");
            }
            else if (num1 < num2) {
                return Ok(num2);
            }
            else {
                return Ok(num1);
            }
        }
        
    }
}
