using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class ej10controller : ControllerBase
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
            List<int> pairList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    pairList.Add(i);
                }
                else if (i != 0)
                {
                    oddList.Add(i);
                }
            }

            var listas = new Lists
            {
                PairList = pairList.ToArray(),
                OddList = oddList.ToArray()
            };


            return Ok(listas);


        }
        return BadRequest("Error el intervalo no puede ser mayor a 1000.");
    }
}