using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<decimal> CalcularPago(
            decimal precio,
            int cantidad,
            string formaPago,
            string? numeroTarjeta) 
        {
            if (precio <= 0 || cantidad <= 0)
            {
                return BadRequest("El precio y la cantidad deben ser valores positivos.");
            }

            decimal valorTotal = precio * cantidad;

            switch (formaPago.ToLower())
            {
                case "tarjeta":

                    if (string.IsNullOrWhiteSpace(numeroTarjeta) || numeroTarjeta.Length != 16 )
                    {
                        return BadRequest("Número de tarjeta inválido. Debe tener 16 dígitos.");
                    }

                    decimal valorConRecargo = valorTotal * 1.10m;
                    return Ok(valorConRecargo);

                case "efectivo":

                    return Ok(valorTotal);

                default:

                    return BadRequest("Forma de pago no válida. Debe ser 'tarjeta' o 'efectivo'.");
            }
        }
    }
}
