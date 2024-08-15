using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(decimal price, int quantity, string paymentMethod, string? cardNumber = null)
        {
            if (price <= 0 || quantity <= 0)
            {
                return BadRequest("El precio y la cantidad deben ser valores positivos.");
            }

            decimal totalAmount = price * quantity;

            switch (paymentMethod.ToLower())
            {
                case "tarjeta":
                    if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16)
                    {
                        return BadRequest("Número de tarjeta inválido. Debe tener 16 dígitos.");
                    }

                    totalAmount *= 1.10m;
                    return Ok($"Total a pagar con 10 % de recargo: {totalAmount}");

                case "efectivo":
                    return Ok($"Total a pagar: {totalAmount}");

                default:
                    return BadRequest("Forma de pago no válida. Debe ser 'efectivo' o 'tarjeta'.");
            }
        }
    }
}

