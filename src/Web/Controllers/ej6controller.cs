using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(double inputPrice, string paymentMethod, string cardNumber = null)
        {
            if (inputPrice <= 0)
            {
                return BadRequest("Costo no puede ser menor o igual a 0");
            }

            if (paymentMethod.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (cardNumber == null || cardNumber.Length != 16)
                {
                    return BadRequest("El numero de tarjeta tiene que tener 16 digitos");
                }

                double total = inputPrice * 1.10;
                var response = $"El valor a pagar con tarjeta es: {total}";
                return Ok(response);
            }
            else if (paymentMethod.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
            {
                var response = $"El valor a pagar con efectivo es: {inputPrice}";
                return Ok(response);
            }
            else
            {
                var response = "La forma de pago no es válida. Debe ser 'efectivo' o 'tarjeta'.";
                return BadRequest(response);
            }
        }
    }
}