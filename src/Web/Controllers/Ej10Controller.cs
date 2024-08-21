using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            List<int> numerosPares = new List<int>();
            List<int> divisiblesEntreTres = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }

                if (i % 3 == 0)
                {
                    divisiblesEntreTres.Add(i);
                }
            }

            string paresString = string.Join(", ", numerosPares);
            string divisiblesTresString = string.Join(", ", divisiblesEntreTres);

            StringBuilder resultado = new StringBuilder();
            resultado.AppendLine("Números Pares: " + paresString);
            resultado.AppendLine("Números Divisibles entre 3: " + divisiblesTresString);

            return resultado.ToString();
        }
    }
}
