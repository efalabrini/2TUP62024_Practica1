using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

/// <summary>
/// 6) Reciba el precio de un producto (valor positivo), la cantidad a comprar y la forma de pagar (efectivo o tarjeta).
/// Si la forma de pago es mediante tarjeta, debe recibir también el número de la misma(inventado), 
/// verificar que sean 16 dígitos y retornar el valor a pagar con un 10% de recargo.
/// Si la forma de pago es mediante efectivo, retorna el valor a pagar.
/// Si la forma de pago no es tarjeta ni efectivo, debe retornar un status code del grupo de los 400.
/// </summary>
[ApiController]
[Route("[controller]")]


public class Ej6Controller : ControllerBase {
    [HttpGet]
    public ActionResult Get(float price, int amount, string paymentMethod, string cardNumber)
        {
            float total = 0;
            int newCardNumber = 0;

            paymentMethod = paymentMethod.ToLower().Trim();
            if (price < 0 && amount < 0) return BadRequest("No se pueden ingresar valores negativos");
            if (paymentMethod == "tarjeta")
            {
                bool result = int.TryParse(cardNumber, out newCardNumber);
                if (result && cardNumber.Length == 16)
                {
                total = price * amount * 1.1f;
                return Ok(total);
                }

                else 
                {
                return BadRequest("Número de tarjeta no válido"); 
                }
            }

            else if(paymentMethod == "efectivo"){
            total = price * amount;
            return Ok(total);
            }

            return BadRequest("Método de pago inexistente");

        }
}