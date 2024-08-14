//Recorrer los números del 1 al 100. Usar un bucle for.

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public string Get()
    {
       string resultado = "";

        for (int i = 1; i <= 100; i++)
        {
            resultado += i + "\n";
        }

        return resultado;
    }
}