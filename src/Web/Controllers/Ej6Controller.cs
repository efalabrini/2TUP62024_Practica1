using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] double price, [FromQuery] int quantity, [FromQuery] string payMethod, [FromQuery] string? card)
    {
        if (price < 0)
        {
            return BadRequest("El precio debe ser positivo");
        }

        double total;
        string payMethodRefactor = payMethod.Trim().ToLower();

        if (payMethodRefactor == "efectivo")
        {
            total = price * quantity;
            return Ok($"El valor a pagar es: {total}");
        }
        else if (payMethodRefactor == "tarjeta")
        {
            if (card == null)
            {
                return BadRequest("La tarjeta no puede ser nula.");
            }

            if (card.Length == 16)
            {
                total = (price * quantity) * 1.10; 
                return Ok($"El valor a pagar es: {total}");
            }
            else
            {
                return BadRequest("La tarjeta debe tener 16 dígitos.");
            }
        }
        else
        {
            return BadRequest("Método de pago no válido.");
        }
    }
}

/*
6) Reciba el precio de un producto (valor positivo), la cantidad a comprar y la forma de pagar (efectivo o tarjeta).
Si la forma de pago es mediante tarjeta, debe recibir también el número de la misma(inventado), verificar que sean 16 dígitos y retornar el valor a pagar con un 10% de recargo.
Si la forma de pago es mediante efectivo, retorna el valor a pagar.
Si la forma de pago no es tarjeta ni efectivo, debe retornar un status code del grupo de los 400.

 */