using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(decimal precio, string formaPago, string numeroTarjeta = null)
        {
            // Validar el precio
            if (precio <= 0)
            {
                return BadRequest("El precio debe ser un valor positivo.");
            }

            // Validar la forma de pago
            formaPago = formaPago?.ToLower().Trim();
            if (formaPago != "efectivo" && formaPago != "tarjeta")
            {
                return BadRequest("La forma de pago debe ser 'efectivo' o 'tarjeta'.");
            }

            // Si la forma de pago es tarjeta, validar el número de tarjeta
            if (formaPago == "tarjeta")
            {
                if (string.IsNullOrEmpty(numeroTarjeta) || numeroTarjeta.Length != 16 || !long.TryParse(numeroTarjeta, out _))
                {
                    return BadRequest("El número de tarjeta debe tener 16 dígitos.");
                }

                // Aplicar el recargo del 10%
                decimal recargo = precio * 0.10m;
                precio += recargo;
            }

            // Devolver el valor a pagar
            return Ok($"El valor a pagar es: {precio:C}");
        }
    }
}
