using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery] int num1, [FromQuery] int num2) 
        {
            if (num1 > num2)
            {
                return $"El numero {num1} es mayor que el numero {num2}";
            }
            else if (num1 < num2)
            {
                return $"El numero {num2} es mayor que el numero {num1}";
            }
            else if (num1 == num2) 
            {
                return "Los numeros son iguales";
            }
            else
            {
                return "Algo salio mal, intente nuevamente";
            }
        }
    }
}
