using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ej3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ej3 : ControllerBase
    {
        [HttpGet]
        public string Get(string nombre, int edad){
            return  "Te llamas "+nombre+" y tienes "+edad+"años";
        }
    }
}
