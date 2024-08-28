using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<NumberLists> GetNumberLists()
        {
            List<int> Pares = new List<int>();
            List<int> divisible3 = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    Pares.Add(i);    
                }
                if (i%3 == 0)
                {
                    divisible3.Add(i);
                }
            }

            NumberLists result = new NumberLists
            {
                Pares = Pares,
                divisible3 = divisible3
            };

            return Ok(result);

        }
        public class NumberLists
        {
            public List<int> Pares { get; set; }
            public List<int> divisible3 { get; set; }
        }
    }
}
