using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(float price, int cantToBuy, string metodoDePago, string numTarjeta)
    {
        if (metodoDePago.ToLower().Trim() == "tarjeta")
        {
            if (numTarjeta.Length != 16)
            {
                return BadRequest("La tarjeta tiene que tener 16 dígitos");
            }
            else
            {
                price = cantToBuy * price * 1.10f;
                return Ok($"El total a pagar es de ${price}");
            }
        }
        else if (metodoDePago.ToLower().Trim() == "efectivo")
        {
            price = cantToBuy * price;
            return Ok($"El total a pagar es de ${price}");
        }
        else
        {
            return BadRequest("Método de pago no válido");
        }
    }
}
