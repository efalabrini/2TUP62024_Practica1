using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Web;

[Route("api/[controller]")]
[ApiController]

public class Ej6Controller : ControllerBase
{

    [HttpGet]

    public ActionResult Get(double price, int quantity, string payMethod, string cardNumber)
    {
        if (price <= 0 || quantity <= 0)
        {
            return BadRequest("el precio y la cantidad tiene que ser mayores a cero.");
        }

        double total = price * quantity;

        if (payMethod.ToLower().Trim() == "tarjeta")
        {
            if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16)
            {
                return BadRequest("el numero ingresado tiene que tener 16 caracteres.");
            }

            total += total * 0.10;
        }

        else if (payMethod.ToLower().Trim() != "efectivo")
        {
            return StatusCode(StatusCodes.Status400BadRequest, "metodo de pago no admitido");
        }

        return Ok(total);

    }
}