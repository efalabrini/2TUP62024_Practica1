using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

    public class LinqEj5Controller: ControllerBase
    {
        [HttpGet]


        public ActionResult Get([FromQuery] List<int> powList) 
        {
            var numQuery = powList.Where(num => Math.Pow(num, 2) > 20).Select(num => $"{num} - {Math.Pow(num, 2)}");
            return Ok(numQuery);
        }
    }

