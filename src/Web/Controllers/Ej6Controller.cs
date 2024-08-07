using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int price, int cant, string pay, string cardNumber = null)
        {
            if (price <= 0 || cant <= 0)
            {
                return BadRequest("El precio y la cantidad deben ser valores positivos.");
            }

            // verifica el metodo de pago
            pay = pay?.ToLower().Trim();

        
            int total = price * cant;

            switch (pay)
            {
                case "tarjeta":
                    if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
                    {
                        return BadRequest("Debe ingresar los 16 dígitos de la tarjeta.");
                    }
                    // "double" para calcular el valor para representar nuimeros decimales
                    double totalConRecargo = total * 1.10;
                    return Ok($"El valor a pagar con recargo del 10% es: {totalConRecargo}");

                case "efectivo":
                    return Ok($"El valor a pagar es: {total}");

                default:
                    return BadRequest("El método de pago debe ser 'efectivo' o 'tarjeta'.");
            }
        }
    }
}
