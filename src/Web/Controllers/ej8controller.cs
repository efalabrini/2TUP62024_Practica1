using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class ej8controller : ControllerBase
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

            while (start < end)
            {
                myList.Add(start);
                start++;
            }

            return Ok(myList.ToArray());


        }
        return BadRequest("Error el intervalo no puede ser mayor a 1000.");
    }
}