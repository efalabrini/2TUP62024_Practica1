using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(int numBeg, int numEnd)
    {
        if (numEnd - numBeg < 1000) {
            List<int> listNumber = [];
            for (int i = numBeg; i <= numEnd; i++)
            {
                listNumber.Add(i);
            }
            return Ok(listNumber);
        } else {
            return StatusCode(400);
        }
    }
}
