using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ejercicio6 : ControllerBase{

    [HttpGet]

    public ActionResult Get(int price, int amount, string HtP, string numCard = ""){
        if (HtP.ToLower().Trim() == "efectivo"){
            return Ok(price*amount);
        }else if (HtP.ToLower().Trim() == "tarjeta" && numCard.Length == 16){
            return Ok( price*amount* 1.1);
        }else return StatusCode(400);
    }
}