using Microsoft.AspNetCore.Mvc;

namespace Web;


[ApiController]
[Route("[controller]")]

public class Ej7Controller : ControllerBase {
    [HttpGet]
    public ActionResult Get(int a, int b) {
        if (b - a >= 1000) {
            return StatusCode(400);
        } else {
            var listaNums = new List<int> {a};
            for (int i = a+1; i <= b; i++) {
                listaNums.Add(i);
            }
            return Ok(listaNums);
        }

    }
}