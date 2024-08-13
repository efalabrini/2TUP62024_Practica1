
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<String> nombres)
    {
        return Ok(nombres.Where(nombre => nombre.Length >= 5).Select(nombre => nombre.ToUpper()));
    }
}
