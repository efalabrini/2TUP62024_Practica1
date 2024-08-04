using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{

    [HttpGet]

    public int get(int uno, int dos)
    {
        if (uno > dos)
        {
            return uno;
        }
        else
        {
            return dos;

        }
        
    }

}
