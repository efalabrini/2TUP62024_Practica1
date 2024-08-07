using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class ej9controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get(int start, int end)
    {

        if (start < 0)
        {
            return BadRequest("No se permiten valores negativos en el Inicio!");
        }

        if (end <= 0)
        {
            return BadRequest("No se permiten valores negativos o 0!");
        }

        int result = end - start;

        if (result <= 1000)
        {
            List<int> myList = new List<int>();
            List<int> pairList = new List<int>();

            for (int i = start; i < end; i++)
            {
                myList.Add(i);
            }

            foreach (int num in myList)
            {
                if (num % 2 == 0)
                {
                    pairList.Add(num);
                }
            }

            return Ok(pairList.ToArray());

        }
        return BadRequest("Error el intervalo no puede ser mayor a 1000.");
    }
}