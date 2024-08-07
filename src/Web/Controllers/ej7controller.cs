using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public int Get()
        {
            var cont = 0;

            for (int i = 0; i <= 100; i++)
            {
                cont = i;
            }
            return cont;
        }
    }
}