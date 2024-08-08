using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]


public class Ej6Controller : ControllerBase {
    [HttpGet]
    public ActionResult Get(int price, int amount, int opt, string numTarget = "") {
        if (opt == 1) {
            if (numTarget.Length == 16) {
                return Ok(price * amount * 1.1);
            } else 
                {
                    return StatusCode(400);
                }
        } else if (opt == 2) {
            return Ok(price*amount);
        } else {
            return StatusCode(400);
        }
    }
}