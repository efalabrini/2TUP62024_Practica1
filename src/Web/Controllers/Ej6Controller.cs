using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(float price, int quantity, string pay, string cardNumber)
        {
            if(pay.ToLower() == "tarjeta")
            {
                if(cardNumber is null)
                {
                    return BadRequest("tarjeta invalida");
                }
                if (cardNumber.Length != 16)
                {
                    return BadRequest("el numero de la tarjeta debe contener 16 caracteres");
                }
                return Ok((price * 1.10) * quantity);
            }
            else if(pay.ToLower() == "efectivo")
            {
                return Ok(price * quantity);
            }
            else
            {
                return BadRequest("forma de pago no autorizada");
            }
        }
    }
}
