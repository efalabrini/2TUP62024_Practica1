using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(double price, int quantity, string payment, string numCard)
    {
        if (price < 0) {
            return BadRequest("El precio no puede ser negativo.");

        } else if (quantity < 0){
            
            return BadRequest("La cantidad no puede ser negativa.");
        }
        else if (payment.ToLower() == "tarjeta"){
            if (numCard.Length == 16){

                
                return Ok($"El valor a pagar es $ {price * quantity * 1.10}");
            } else {

                return BadRequest("Datos de tarjeta incorrectos.");
            }

        } else if (payment.ToLower() == "efectivo"){

            return Ok($"El valor a pagar es $ {price * quantity}");
        } else {

            return BadRequest("Datos incorrectos.");

        }

    }
}