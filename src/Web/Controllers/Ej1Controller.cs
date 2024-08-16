using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class Ej1Controller: ControllerBase
    {
        [HttpGet]
        public int Get(int num1, int num2, int num3) {
            return num1 + num2 + num3;
        }
    }
}
