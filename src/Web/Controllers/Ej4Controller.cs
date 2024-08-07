using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej4Controller : ControllerBase
{
    [HttpGet]

    public string Get(int numero1, int numero2)
    {
        if(numero1 > numero2){
            return $"El mayor número es {numero1}";
        } 
        else if (numero2 > numero1){
            return $"El mayor número es {numero2}";
        }
        else{
            return "Los números son iguales";
        }
    }
}