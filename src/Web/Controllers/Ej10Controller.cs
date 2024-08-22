using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            List<int> pares = [];
            List<int> impares = [];

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pares.Add(i);

                    if (i % 3 == 0) 
                    {
                        impares.Add(i);
                    }
                }
                else if (i % 3 == 0)
                {
                    impares.Add(i);
                }
            }


            return $"Los números pares son: {string.Join(", ", pares)}\nLos números divisibles por 3 son: {string.Join(", ", impares)}";
        }
    }
}
