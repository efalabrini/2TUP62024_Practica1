using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej5Linqcontroller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<int> numbers)
    {
        
        var numbersQuery=
            from num in numbers
            let numXnum=num*num
            where numXnum > 20
            select new{
                number = num,
                NumXnum = numXnum,
            };
        return Ok(numbersQuery);


            
    }
}