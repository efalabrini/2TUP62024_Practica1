// 6) Reciba el precio de un producto (valor positivo), la cantidad a comprar y la forma de pagar (efectivo o tarjeta).
// Si la forma de pago es mediante tarjeta, debe recibir también el número de la misma(inventado), verificar que sean 16 dígitos y retornar el valor a pagar con un 10% de recargo.
// Si la forma de pago es mediante efectivo, retorna el valor a pagar.
// Si la forma de pago no es tarjeta ni efectivo, debe retornar un status code del grupo de los 400.


using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get(int amount , float price , string pay , string numberCard = "")
    {
        
        if (price <= 0 || amount <= 0)
        {
            return BadRequest("el precio y la cantidad debern ser positivos");
        }
         var total = price * amount;

        if(pay == "tarjeta")
        {
            if(numberCard.Length < 16 || numberCard.Length >16){

                return BadRequest("Tiene que ingresar 16 digitos");
            }

           
            var totalvalue=total *1.10;
            return Ok($"el precio es{totalvalue}");
        }
        else if (pay == "efectivo")
        {
            return Ok($"el precio es {total}");


        }

        else
        {
            return BadRequest("no es una opcion valida");
        }





    }




}
