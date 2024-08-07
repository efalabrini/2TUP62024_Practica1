using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej8Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int numBeg, int numEnd)
    {
        if (numEnd - numBeg < 1000)
        {
            List<int> listNumber = [];
            int index = numBeg;
            while (index <= numEnd)
            {
                listNumber.Add(index);
                index++;
            }
            return Ok(listNumber);
        }
        else
        {
            return StatusCode(400);
        }
    }
}
