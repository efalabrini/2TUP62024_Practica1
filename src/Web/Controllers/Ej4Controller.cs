using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public int Get(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
