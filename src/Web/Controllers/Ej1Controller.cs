using Microsoft.AspNetCore.Mvc;

namespace Web;

[Route("api/[controller]")]
[ApiController]

public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public int Get(int uno, int dos, int tres)
    {
        int suma = uno + dos + tres;
        return suma;
    }
}
