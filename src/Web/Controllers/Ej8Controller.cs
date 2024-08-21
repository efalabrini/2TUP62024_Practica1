using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PagoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            StringBuilder numeros = new StringBuilder();

            int i = 1;

            while (i <= 100)
            {
                numeros.Append(i.ToString());

                if (i < 100)
                {
                    numeros.Append(", ");
                }

                i++;
            }

            return numeros.ToString();
        }
    }
}
