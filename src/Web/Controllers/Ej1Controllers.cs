using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej1Controllers : ControllerBase
{
    [HttpGet]
    public int Get(int uno, int dos, int tres)
    {
        return uno + dos + tres;
    }
}
