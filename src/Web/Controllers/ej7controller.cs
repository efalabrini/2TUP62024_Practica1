using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class ej7controller : ControllerBase
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

            for (int i = start; i < end; i++)
            {
                myList.Add(i);
            }

            return Ok(myList.ToArray());


        }
        return BadRequest("Error el intervalo no puede ser mayor a 1000.");
    }
}