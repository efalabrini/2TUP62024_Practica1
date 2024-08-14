using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpGet] //decorador 
    public string Get(int uno, int dos)
    {
        if (uno>dos){
            return $"el mayor es: {uno}";
        }
        else if (dos>uno){
            return $"el mayor es: {dos}";
        }
        else{
            return "los numeros son iguales";
        }
    }
}
// hacer pull 