using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Web.Controllers { 
[ApiController]
[Route("[controller]")]
public class Ej4LinqController : Controller
{
    [HttpGet]
    public List<int> Get([FromQuery] List<int> numList)
        {
            var query = (from int num in numList
                         orderby num descending
                         select num).Take(5);

            return query.ToList();
        }

    
}
}