using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] double price, [FromQuery] string MethodPay, [FromQuery] string? Card) // Permitir null en Card
        {
            if (price <= 0)
            {
                return BadRequest("El valor debe ser mayor a 0");
            }

            if (MethodPay.Equals("Tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                // Valida el num de tarjeta, solo si se elige este metodo de pago --> if (string.IsNullOrEmpty(Card)
                if (string.IsNullOrEmpty(Card) || Card.Length != 16) 
                    return BadRequest("La tarjeta debe tener 16 dígitos en total");

                double FinalPrice = price * 1.10;
                string Payment = $"El precio final al abonar con tarjeta es de {FinalPrice}";
                return Ok(Payment);
            }
            else if (MethodPay.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
            {
                // No se requiere número de tarjeta para pagos en efectivo
                string Payment = $"El precio final en efectivo es de {price}";
                return Ok(Payment);
            }
            else
            {
                // Retorna un error si el método de pago no es ni "Tarjeta" ni "Efectivo"
                return BadRequest("ERROR, el método de pago debe ser 'Tarjeta' o 'Efectivo'");
            }
        }
    }
}
