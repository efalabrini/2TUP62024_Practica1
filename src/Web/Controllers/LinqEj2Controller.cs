using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var filteredWords = words.Where(word => word.Length >= 5).Select(word => word.ToUpper());
        var result = filteredWords.ToList();

        return Ok(result);
    }
}