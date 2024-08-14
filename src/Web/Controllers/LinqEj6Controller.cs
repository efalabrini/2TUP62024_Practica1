using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] List<string> palabras)
    {
        var resultado =  from p in palabras
                         select p.Replace("ia", "*");                  

        return Ok(resultado);
    }
}