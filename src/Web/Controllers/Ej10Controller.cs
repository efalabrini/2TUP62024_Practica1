using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public ActionResult<NumberLists> Get(int numStart, int numEnd)
    {
        List<int> evenList  = [];
        List<int> oddList = [];

        if (numEnd - numStart < 1000)
        {
            for (int i = numStart; i <= numEnd; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                } else {
                    oddList.Add(i);
                }
            }

            var result = new NumberLists
            {
                EvenList = evenList,
                OddList = oddList
            };

            return Ok(result);
        }

        return BadRequest(500);
    }
}



public class NumberLists
{
    public required List<int> EvenList { get; set; }
    public required List<int> OddList { get; set; }
}

