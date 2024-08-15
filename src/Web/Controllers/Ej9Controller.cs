using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string resultado = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    resultado += i + "\n";
                }
            }

            return resultado;
        }
    }
}
