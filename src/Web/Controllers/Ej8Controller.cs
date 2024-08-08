using Microsoft.AspNetCore.Mvc;

namespace Web;


[ApiController]
[Route("[controller]")]

public class Ej8Controller : ControllerBase {
    [HttpGet]
    public ActionResult Get(int a, int b) {
        if (b - a >= 1000) {
            return StatusCode(400);
        } else {
            var listaNums = new List<int> {a};
            int i = a+1;
            while ( i <= b) {
                listaNums.Add(i);
                i++;
            }
            return Ok(listaNums);
        }

    }
}