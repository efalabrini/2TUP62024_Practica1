using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]

    
    public class Ej1controller : Controller
    {
        [HttpGet()]
        public int Get(int num1, int num2, int num3) 
        { 
            int resultado = num1 + num2 + num3;
            return resultado;
        
        }
    }
}
