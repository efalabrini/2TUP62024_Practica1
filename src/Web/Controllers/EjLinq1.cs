using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class EjLinq1: ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        List<int> numbers = new List<int> { 10,52,45,12,35,47,812,44,151,42,512};

        var numQuery = from number in numbers 
                       where (number > 30 && number < 100) 
                       select number;
     
  
        return Ok(numQuery.ToList());
        }    
       
    }
