using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ejercicio7 : ControllerBase{

    [HttpGet]
    public ActionResult Get(int Num1, int Num2){
        if (Num2 - Num1 > 1000){
            return StatusCode(400);

        }else {
            var ListaNums =  new List<int> {Num1};
            for (int i= Num1+1; i <= Num2; i++){
                ListaNums.Add(i);
            }
            return Ok(ListaNums);
        }
    }
}