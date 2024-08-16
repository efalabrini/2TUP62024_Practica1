using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(decimal precio, int cantidad, string formaPago, string? numeroTarjeta)
        {
            if (precio <= 0 || cantidad <= 0)
            {
                return BadRequest("El precio y la cantidad deben ser mayores a 0.");
            }

            decimal total = precio * cantidad;

            if (formaPago.ToLower() == "tarjeta")
            {
                if (numeroTarjeta != null && numeroTarjeta.Length == 16)
                {
                    total *= 1.1m;
                    return Ok($"El total a pagar con recargo es: {total:C}");
                }
                else
                {
                    return BadRequest("Número de tarjeta inválido. Debe tener 16 dígitos.");
                }
            }
            else if (formaPago.ToLower() == "efectivo")
            {
                return Ok($"El total a pagar es: {total:C}");
            }
            else
            {
                return BadRequest("Forma de pago no válida.");
            }
        }
    }
}
