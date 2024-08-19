using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj7controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        string sentence = "ESTO es un EJEMPLO del EJERcicio";

        List<string> result = sentence.Split(" ").Where(x => x.All(char.IsUpper)).ToList();

        return Ok(result);
    }
}
