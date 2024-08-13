
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<String> nombres)
    {
        return Ok(nombres.Where(nombre => nombre.ToLower().StartsWith('b') && nombre.ToLower().EndsWith('r')));
    }
}
