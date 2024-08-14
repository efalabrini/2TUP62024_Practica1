using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj2controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<string> sentences = ["Computadora", "hora", "Hola", "Telefono"];

        List<string> result = sentences.Where(x => x.Length > 5).Select(s => s.ToUpper()).ToList();

        return Ok(result);
    }
}
