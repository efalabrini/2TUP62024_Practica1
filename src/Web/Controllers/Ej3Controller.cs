using Microsoft.AspNetCore.Mvc;

namespace Web;

[Route("api/[controller]")]
[ApiController]

public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get(string name, int age)
    {
        string msj = $"Te llamas {name} y tienes {age} anos";
        return Ok(msj);
    }
}