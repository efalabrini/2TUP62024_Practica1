using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6Controllers : ControllerBase
{

    [HttpGet]
    public ActionResult Get(int price, string pay, string number = "")
    {

        if (price < 1)
        {
            return Ok("Ingrese una cantidad mayor a 0");
        }

        if (pay.ToLower().Trim() == "tarjeta")
        {
            if (number.Length < 16)
            {
                return Ok("Ingrese un numero mayor a 16 digitos");
            }
            return Ok($"El monto a pagar en tarjeta es de: {price * 1.1}");
        }
        else if (pay.ToLower().Trim() == "efectivo")
        {

            return Ok("El monto a pagar en efectivo es de: " + price);
        }
        else
        {
            return StatusCode(400);
        }



    }
}