using Microsoft.AspNetCore.Mvc;
using System;


namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] float precio, [FromQuery] int cantidad, [FromQuery] string formaPago, [FromQuery] string numeroTarjeta = "")
        {
            if (precio <= 0)
            {
                return BadRequest("El precio del producto debe ser un valor positivo.");
            }

            if (cantidad <= 0)
            {
                return BadRequest("La cantidad a comprar debe ser un valor positivo.");
            }

            double valorTotal = precio * cantidad;

            formaPago = formaPago.Trim().ToLower();

            if (formaPago == "tarjeta")
            {
                if (string.IsNullOrWhiteSpace(numeroTarjeta))
                {
                    return BadRequest("Debe proporcionar un número de tarjeta.");
                }

                numeroTarjeta = numeroTarjeta.Trim();

                if (numeroTarjeta.Length != 16)
                {
                    return BadRequest("El numero de tarjeta debe tener 16 digitos");
                }

                valorTotal = valorTotal * 1.10;
                return Ok($"El valor a pagar es:{valorTotal}");
            }
            else if (formaPago == "efectivo")
            {
                return Ok($"El valor a pagar es: {valorTotal}");
            }
            else
            {
                return BadRequest("La forma de pago no es válida.");
            }
        }
    }
}
