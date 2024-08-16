using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public int Get(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
