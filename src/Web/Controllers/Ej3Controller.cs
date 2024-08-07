

using Microsoft.AspNetCore.Mvc;

namespace  Web;

[ApiController]
[Route("controller")]

public class Ej3Controller : ControllerBase {
    [HttpGet]

    public string Get(int Edad, string Nombre) {
        return $"Te llamas {Nombre} y tienes {Edad} años!";
    }
}
