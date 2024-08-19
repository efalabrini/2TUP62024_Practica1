using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj6controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        List<string> sentences = ["estudiar", "caminar", "dia"];

        List<string> result = sentences.Select(x => x.Replace("ia", "*")).ToList();

        return Ok(result);
    }
}
