using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int price, int amount, string payment, string numCard = "")
    {
        if (price > 0 && amount > 0){
            switch (payment.ToLower().Trim())
            {
                case "efectivo":
                    return Ok(price * amount);
                case "tarjeta":
                    if (numCard.Length == 16) {
                        int subtotal = price * amount;
                        return Ok(subtotal + (subtotal * 0.1));
                    } else {
                        return StatusCode(400);
                    }
                default:
                    return StatusCode(400);
            }
        } else {
            return StatusCode(400);
        }
    }
}
