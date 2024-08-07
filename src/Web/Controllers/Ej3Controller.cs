using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]

public class Ej3Controller : ControllerBase
{

    [HttpGet]

    public string get(string nombre, int edad)
    {
        return $"hola {nombre}, tenes {edad} años";
    }

}
