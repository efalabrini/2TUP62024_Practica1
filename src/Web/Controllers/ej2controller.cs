using Microsoft.AspNetCore.Mvc;

namespace Web;

[Route("api/[controller]")]
[ApiController]

public class Ej2Controller : ControllerBase
{

[HttpGet]

public ActionResult Get(string person, string city) {
    string msj = $"Hola {person} bienvenido a {city}";
    return Ok (msj);
}
}

