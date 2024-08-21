using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class LinqEj4Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {

        var numQuery = (from number in numbers
                        orderby number descending
                        select number).Take(5);


        return Ok(numQuery);
    }

}