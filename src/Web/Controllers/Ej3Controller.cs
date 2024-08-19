using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : Controller
    {
        [HttpGet]
        public string Get(string name, string age) { 
            string message = $"Te llamas {name} y tienes {age} años";
            return message;
        }
    }
}
