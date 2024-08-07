using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public string Get(string day)
        {
            if (day.ToLower() == "sabado" || day.ToLower() == "domingo")
            {
                return $"{day} no es un dia de la semana";
            }
            else
            {
                return $"{day} es un dia de la semana";
            }
        }
    }
}
