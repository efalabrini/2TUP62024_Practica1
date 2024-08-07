using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            int num = 0;

            for (int i = 1; i <= 100; i++)
            {
                num = i;
            }

            return num; 
        }
    }
}
