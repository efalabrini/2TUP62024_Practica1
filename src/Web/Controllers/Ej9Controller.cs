using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
{
    [HttpGet]
    public ActionResult<List<int>> Get(int inicio, int fin)
    {
        if (fin - inicio >= 1000)
        {
            return BadRequest("La diferencia es mayor o igual a 1000");
        }

        List<int> numerosPares = new List<int>();

        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                numerosPares.Add(i);
            }
        }

        return Ok(numerosPares);
    }
}