using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult RealizarPago(decimal precio, string formaPago, string numeroTarjeta = null)
        {
            if (precio <= 0)
            {
                return BadRequest("El precio debe ser un valor positivo");
            }

            if (formaPago == "tarjeta")
            {
                if (string.IsNullOrEmpty(numeroTarjeta) || numeroTarjeta.Length != 16)
                {
                    return BadRequest("El número de tarjeta es obligatorio y debe tener 16 dígitos");
                }

                var recargo = precio * 0.10m;
                var total = precio + recargo;

                return Ok(new { Total = total });
            }
            else if (formaPago == "efectivo")
            {
                if (!string.IsNullOrEmpty(numeroTarjeta))
                {
                    return BadRequest("No se requiere número de tarjeta para pago en efectivo");
                }

                return Ok(new { Total = precio });
            }
            else
            {
                return BadRequest("La forma de pago no es válida");
            }
        }
    }
}
