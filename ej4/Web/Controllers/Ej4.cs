using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4 : ControllerBase
    {
        [HttpGet]
        public int Get(int num1,int num2){
            if(num1>num2){
                return num1;
            }
            return num2;
        }
    }
}
