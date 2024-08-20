using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej5controller : ControllerBase
{
    [HttpGet]


    public IActionResult Get(string day)
    {
        string[] DayOfWeek = ["lunes","martes","miercoles", "jueves", "viernes"];
        string[] DaysOfWeekend = ["sabado","domingo"];

    day = day.ToLower().Trim();
    if (DayOfWeek.Contains(day))
    {
        return BadRequest("Ese dia no pertenece a un dia de fin de semana");
    }else if (DaysOfWeekend.Contains(day))
    {
        return Ok("Ese dia pertenece a un dia del fin de semana");
    }
    return StatusCode(StatusCodes.Status500InternalServerError,"Error: el dia ingresado no existe");
    }	
}