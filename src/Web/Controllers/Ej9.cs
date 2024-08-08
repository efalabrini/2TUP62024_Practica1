using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ejercicio9 : ControllerBase{

    [HttpGet]
    public ActionResult Get(int Num1, int Num2){
        if (Num2 - Num1 > 1000){
            return StatusCode(400);

        }else {
            var ListaNums =  new List<int> {Num1};
            int i= Num1+1;
            while (i <= Num2){
                ListaNums.Add(i);
                i++;
            }
            var ListaPares = new List<int> {};
            foreach(int num in ListaNums){
                if (num % 2 == 0){
                    ListaPares.Add(num);
                }
            }
            return Ok(ListaPares);
        }
    }
}