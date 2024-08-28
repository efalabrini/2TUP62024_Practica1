using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]


public class Ej5linqController : ControllerBase {
    [HttpGet]
    public ActionResult Get([FromQuery]List<int> numbers) {
        
        var numbersSqr = new List<string>();

        foreach (int n in numbers){
            int square = n*n;
            if (square > 20){
                numbersSqr.Add($"{n} - {square}");
            }
        }
        return Ok(numbersSqr);
    }
}