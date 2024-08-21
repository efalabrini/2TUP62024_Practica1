using Microsoft.AspNetCore.Mvc;
using System;
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

            for (int i = 1; i <= 100; i++)
            {
                numeros.Append(i.ToString());

                if (i < 100)
                {
                    numeros.Append(", ");
                }
            }

            return numeros.ToString();
        }
    }
}
