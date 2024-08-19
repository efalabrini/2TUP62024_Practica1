using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6controller : ControllerBase
{

    [HttpGet]
    public IActionResult Get(float price, int amount, string method, string cardNumber)
    {
        float total;

        if (price <= 0 || amount <= 0)
        {
            return BadRequest("El precio y la cantidad deben ser mayores a 0");
        }

        total = price * amount;        

        method = method.Trim().ToLower();

        if (method == "tarjeta")
        {
            if (cardNumber.Length != 16)
            {
                return BadRequest("El número de tarjeta debe ser de 16 dígitos");
            } else
            {
                total = total * 1.1f;
                return Ok(total);
            }     
        }
        else if (method == "efectivo")
        {
            return Ok(total);
        }
        else
        {
            return BadRequest("Introduzca un método de pago válido");
        }
    }
}
