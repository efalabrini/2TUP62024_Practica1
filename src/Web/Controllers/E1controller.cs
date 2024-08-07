using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

//1) Reciba 3 valores numéricas y retorne la suma de las mismas

[ApiController]
[Route("[controller]")]
public class E1controller : ControllerBase
{
    [HttpGet]
    public int Get(int uno, int dos, int tres)
    {
        return uno + dos + tres;
    }
}