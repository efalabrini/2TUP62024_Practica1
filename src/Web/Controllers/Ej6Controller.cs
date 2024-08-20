using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int price, int amount, string pay, string numerCard = "")
    {
        if (price <= 0 || amount <= 0)
        {
            return BadRequest("error: el precio y la cantidad deben ser positivos.");
        }
        var totall = price * amount;

        if (pay == "tarjeta")
        {
            if (numerCard.Length != 16)
            {
                return BadRequest("el numero de la tarjeta debe ser de 16 digitos.");
            }
            var totalvalue = totall * 1.10;
            return Ok($"el precio final en tarjeta es: {totalvalue}");
        }
        else if (pay == "efectivo")
        {
            return Ok($"el precio con efectivo es: {totall}");
        }
        else
        {
            return BadRequest("error: opcion invalida.");
        }
    }
}

