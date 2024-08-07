using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ej6controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int price_unitary, int quantity, string pay_form, string credit_number = "")
    {
        if (price_unitary <= 0)
        {
            return BadRequest("Ingrese un precio unitario positivo o mayor a 0.");
        }

        if (quantity <= 0)
        {
            return BadRequest("Ingrese una cantidad positiva o mayor a 0.");
        }

        pay_form.ToLower().Trim();

        if (pay_form == "efectivo")
        {
            var response = $"El total es: ${price_unitary * quantity}";
            return Ok(response);
        }
        else if (pay_form == "credito")
        {
            if (credit_number.Length == 16)
            {
                price_unitary *= quantity;
                int price_increase = price_unitary + (price_unitary * 10 / 100);
                var response = $"El total es: ${price_increase}";
                return Ok(response);
            }
            else
            {
                return BadRequest("Ingrese los 16 digitos.");
            }
        }
        else if (string.IsNullOrEmpty(pay_form))
        {
            return BadRequest("Ingrese un tipo de pago.");
        }

        return BadRequest("Surgio un Error!!");
    }
}
