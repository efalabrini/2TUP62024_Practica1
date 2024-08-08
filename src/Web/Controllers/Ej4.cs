using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ejercicio4 : ControllerBase{

    [HttpGet]
    public int Get(int Num1, int Num2 ){
        if (Num1 > Num2)return Num1;
        else return Num2;
    }
}

