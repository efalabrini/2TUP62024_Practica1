using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj3controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<string> sentences = ["ventilador", "reloj", "buscador"];

        List<string> result = sentences.Where(x => x.StartsWith("b") && x.EndsWith("r")).ToList();

        return Ok(result);
    }
}
