using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ6Controllerwebapi : ControllerBase
    {
        [HttpPost]
        public IActionResult CalcularPago(decimal precio, int cantidad, string formaPago, string numeroTarjeta = null)
        {
            // Validar el precio y la cantidad
            if (precio <= 0)
            {
                return BadRequest("El precio debe ser un valor positivo.");
            }

            if (cantidad <= 0)
            {
                return BadRequest("La cantidad debe ser un valor positivo.");
            }

            // Calcular el monto inicial
            decimal montoTotal = precio * cantidad;

            // Validar la forma de pago
            formaPago = formaPago?.ToLower().Trim();
            if (formaPago == "tarjeta")
            {
                // Validar el número de tarjeta
                if (string.IsNullOrEmpty(numeroTarjeta) || numeroTarjeta.Length != 16 || !long.TryParse(numeroTarjeta, out _))
                {
                    return BadRequest("El número de tarjeta debe tener 16 dígitos.");
                }

                // Aplicar el recargo del 10%
                decimal recargo = montoTotal * 0.10m;
                montoTotal += recargo;
            }
            else if (formaPago != "efectivo")
            {
                // Si la forma de pago no es ni tarjeta ni efectivo, retornar un status code 400
                return BadRequest("La forma de pago debe ser 'efectivo' o 'tarjeta'.");
            }

            // Retornar el monto total a pagar
            return Ok($"El valor a pagar es: {montoTotal:C}");
        }
    }
}

