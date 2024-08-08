using Microsoft.AspNetCore.Mvc;

namespace Web;


[ApiController]
[Route("[controller]")]

public class Ej9Controller : ControllerBase {
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
            var listPares = new List<int> {};
            foreach(int num in listaNums) {
                if (num % 2 == 0)
                    listPares.Add(num);
            }
            return Ok(listPares);
        }

    }
}