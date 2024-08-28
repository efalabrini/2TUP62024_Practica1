using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controllers : ControllerBase
    {
        [HttpGet]

        public int Get(int uno, int dos, int tres)
        {
            return uno + dos + tres;
        }
    }
}
