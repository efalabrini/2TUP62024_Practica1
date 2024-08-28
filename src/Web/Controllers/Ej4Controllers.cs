using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controllers : ControllerBase
    {
        [HttpGet]
        public string Get(int num1, int num2)
        {
            if (num1 > num2)
            {
                return $"El numero mayor es: {num1}";
            }
            else if (num2 > num1)
            {
                return $"El numero mayor es: {num2}";
            }else
            {
                return "Los numeros son iguales";
            }
        }
    }
}
