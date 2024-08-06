using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] double precio, [FromQuery] string pago, [FromQuery] string numTarjeta = null)
        {
            string respuesta;

            if (precio <= 0)
            {
                return "Costo no puede ser menor o igual a 0";
            }

            if (pago.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (numTarjeta == null || numTarjeta.Length != 16)
                {
                    return "El número de la tarjeta debe tener 16 dígitos";
                }

                double total = precio * 1.10;
                respuesta = $"El valor con tarjeta es: {total}";
                return respuesta;
            }
            else if (pago.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
            {
                respuesta = $"El valor en efectivo es: {precio}";
                return respuesta;
            }
            else
            {
                respuesta = "El método de pago no es válido. Debe ser 'efectivo' o 'tarjeta'.";
                return respuesta;
            }
        }
    }
}
}
