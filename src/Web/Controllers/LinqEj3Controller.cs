using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var filteredWords = words.Where(word => word.StartsWith("b") && word.EndsWith("r")).Select(word => word);
        var result = filteredWords.ToList();

        return Ok(result);
    }
}

