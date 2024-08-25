using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej4linqController : ControllerBase {
    [HttpGet]
    public ActionResult Get([FromQuery]List<int> numbers) {
        var fiveSortedNumbers = numbers.OrderByDescending(x=>x).Take(5).ToList();
        
        return Ok(fiveSortedNumbers);
    }
}