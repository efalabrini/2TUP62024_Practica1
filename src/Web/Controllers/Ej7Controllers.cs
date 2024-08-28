using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controllers : ControllerBase
    {
        [HttpGet]

        public int Get() 
        {
            int contador = 1;

            while (contador < 100)
            {
                contador++;
            }

            return contador;
        }
    }
}
