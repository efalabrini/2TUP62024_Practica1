using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] int num1, [FromQuery] int num2)
        {
            if (num1 > num2)
            {
                return $"El numero mayor es: {num1}";
            }
            else if (num2 > num1)
            {
                return $"El numero mayor es: {num2}";
            }
            else
            {
                return "Los numeros son iguales";
            }
        }
    }
}
