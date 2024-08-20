using Microsoft.AspNetCore.Mvc;


namespace System.Text.RegularExpressions;


[ApiController]
[Route("[controller]")]

  
  public class Eje6Controller : Controller
   {
        public ActionResult Payment(float price, int amount, string paymentMethod, string cardNumber)
        {
            paymentMethod = paymentMethod.ToLower().Trim();
            var rgx = new Regex(@"^[0-16]{16}$");
            if (price < 0 && amount < 0) return BadRequest("No se pueden ingresar valores negativos");
            if (paymentMethod == "tarjeta")
            {
                if (rgx.IsMatch(cardNumber))
                {
                var total = price * amount * 1.1;
                return Ok(total);
                }
                else 
                {
                BadRequest("Número de tarjeta no válido"); 
                }
            }
            else if(paymentMethod == "efectivo")
            {
            var total = price * amount;
            return Ok(total);
            }
            else 
            {
            return BadRequest("Método de pago inexistente");
            }

        }
   }

