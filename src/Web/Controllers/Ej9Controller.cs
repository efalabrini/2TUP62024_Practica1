using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
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
                if (index % 2 == 0)
                {
                    listNumber.Add(index);
                }
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