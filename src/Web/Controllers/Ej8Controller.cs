using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string resultado = "";
            int i = 1;

            while (i <= 100)
            {
                resultado += i + "\n";
                i++;
            }

            return resultado;
        }
    }
}