using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(decimal precio, int cantidad, string formaDePago, string? numeroTarjeta = null)
    {
        if (precio <= 0)
        {
            return BadRequest("El precio debe ser un valor positivo.");
        }

        decimal valorAPagar = precio * cantidad;

        if (formaDePago.ToLower() == "tarjeta")
        {
            if (string.IsNullOrEmpty(numeroTarjeta) || numeroTarjeta.Length != 16 || !numeroTarjeta.All(char.IsDigit))
            {
                return BadRequest("El número de tarjeta debe tener 16 dígitos.");
            }
            valorAPagar *= 1.10m;
        }
        else if (formaDePago.ToLower() != "efectivo")
        {
            return BadRequest("La forma de pago debe ser 'tarjeta' o 'efectivo'.");
        }

        return Ok($"El valor a pagar es: {valorAPagar:C}");
    }
}