using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<string> list)
        {
            if (list == null || list.Count == 0) 
            {
                return BadRequest("list should not be empty!");
            }
            var filteredWords = list
                .Where(character => character.Length >= 5)
                .Select(character => character.ToUpper())
                .ToList();
            return Ok(filteredWords);
        }

    }
}
