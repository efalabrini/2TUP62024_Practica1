using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public string Get(int num1, int num2)
        {
            if (num1 > num2) 
            {
                return $"El número {num1} es mayor que {num2}";
            }
            else if (num2 > num1)
            {
                return $"El número {num2} es mayor que {num1}";
            }
            else
            {
                return "Los números son iguales";
            }
        }
    }
}
