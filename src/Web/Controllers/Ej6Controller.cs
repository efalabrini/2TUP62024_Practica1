using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(float price, int amount, string payType, string cardNumber)
    {
        if(price <= 0 || amount <= 0)
        {
            return BadRequest("Los valores no pueden ser negativos");
        }

        payType = payType.ToLower().Trim();

        switch (payType)
        {
            case "tarjeta":
                {
                    if (cardNumber.Length != 16)
                    {
                        return BadRequest("La tarjeta debe tener 16 dígitos");
                    }

                    return Ok(price * amount * 1.10f);

                }
            case "efectivo":
                {
                    return Ok(price * amount);
                }
            default:
                {
                    return StatusCode(400, "Debe pagar con tarjeta o efectivo");
                }
        }
    }
}
