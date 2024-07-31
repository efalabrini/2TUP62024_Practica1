using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ej2controller : ControllerBase
{




    public ej2controller()
    {

    }

    [HttpGet]
    public string Get()
    {


        return "";
    }
}
