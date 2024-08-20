using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[ApiController]
[Route("[controller]")]

  public class Eje6Controller : Controller
   {
        public ActionResult Payment(float price, int amount, string paymentMethod)
        {
            if (price < 0 && amount < 0) return StatusCode(400, "No se pueden ingresar valores negativos");
            

        }
   }

