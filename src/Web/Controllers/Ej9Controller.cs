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
            StringBuilder numerosPares = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Append(i.ToString());

                    if (i < 100)
                    {
                        numerosPares.Append(", ");
                    }
                }
            }

            return numerosPares.ToString();
        }
    }
}
