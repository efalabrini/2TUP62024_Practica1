using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public int Get(int numUno, int numDos, int numTres)
    {
        return numUno + numDos + numTres;
    }
}
