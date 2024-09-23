using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet]


        public ActionResult Get([FromQuery] List<int> listNumbers)
        {
            var numQuery =
                (from num in listNumbers
                orderby num descending
                select num).Take(5);

            return Ok(numQuery);
        }

    }

