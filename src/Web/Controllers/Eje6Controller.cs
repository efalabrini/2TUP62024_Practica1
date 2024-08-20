using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers;


[ApiController]
[Route("[controller]")]

  
  public class Eje6Controller : Controller
   {    
    [HttpGet]
        public ActionResult Payment(float price, int amount, string paymentMethod, string cardNumber)
        {
            paymentMethod = paymentMethod.ToLower().Trim();
            if (price < 0 && amount < 0) return BadRequest("No se pueden ingresar valores negativos");
            if (paymentMethod == "tarjeta")
            {
                if (cardNumber.Length == 16)
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
            
            return BadRequest("Método de pago inexistente");
            

        }
   }

