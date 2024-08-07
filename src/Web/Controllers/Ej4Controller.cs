using Microsoft.AspNetCore.Mvc;

namespace Web;

[Route("api/[controller]")]
[ApiController]

public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public ActionResult<int> Get(int uno, int dos)
    {
        if (uno > dos)
        {
            return Ok($"El numero mayor es el uno: {uno}");
        }
        else
        {
            return Ok($"El numero mayor es el dos: {dos}");
        }
    }
}