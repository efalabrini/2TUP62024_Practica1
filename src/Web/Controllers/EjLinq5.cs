using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class EjLinq5 : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {

        var numQuery = from number in numbers
                        where number*number >= 20
                        select $"{number} - {number*number}";


        return Ok(numQuery);
    }

}