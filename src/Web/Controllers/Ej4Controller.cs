using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

//4) Reciba dos números y retorne el mayor

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet]
    public int Get(int  numero_a, int numero_b)
    {
        if(numero_a>numero_b){
            return numero_a;
        }else{
            return numero_b;
        }
    }
}