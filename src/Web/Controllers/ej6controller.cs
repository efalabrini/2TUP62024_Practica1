using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class ej6controller : ControllerBase
{
    [HttpGet]
    public string Get(int price, string pay_form)
    {
        pay_form.ToLower().Trim();

        if (pay_form == "efectivo")
        {
            return $"El total es: {price}";
        }
        else if (pay_form == "credito")
        {
            int price_increase = price + (price * 10 / 100);
            return $"El total es: {price_increase}";
        }
        else
        {
            return "Ingrese los valores";
        }
    }
}
