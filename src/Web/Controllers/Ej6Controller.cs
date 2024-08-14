/* Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago 
es mediante tarjeta, pedir el número de la misma(inventado), verificar que sean 16 dígitos e informar el valor a pagar con 
un 10% de recargo.*/

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public string Get(int price, string paymentMethod, string cardNumber = null)
    {
        paymentMethod = paymentMethod.Trim();

       if (price <= 0)
            {
                return "Error: El precio debe ser un valor positivo.";
            }

            if (paymentMethod.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
            {
                return $"El valor a pagar es {price} con efectivo.";
            }
            else if (paymentMethod.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (!string.IsNullOrEmpty(cardNumber) && cardNumber.Length == 16 && long.TryParse(cardNumber, out _))
                {
                    double recargo = 0.10 * price;
                    double total = price + recargo;
                    return $"El valor a pagar con tarjeta es {total}.";
                }
                else
                {
                    return "El número de tarjeta debe tener 16 dígitos.";
                }
            }
            else
            {
                return "Forma de pago no válida.";
            }

    }
}