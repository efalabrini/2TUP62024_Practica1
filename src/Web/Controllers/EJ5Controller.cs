using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class EJ5Controller:ControllerBase
{
    [HttpGet]
    public IActionResult GetDayType([FromQuery] string day)
    {
        if (string.IsNullOrWhiteSpace(day))
        {
            return BadRequest("el nombre del dia no puede estar vacio");
        }

        day = day.Trim();

        if(Enum.TryParse(day,true,out DayOfWeek parsedDay))
        {
            bool Isweekend = parsedDay == DayOfWeek.Saturday || parsedDay == DayOfWeek
            return Ok(Isweekend ? "es fin de semana" : "no es fin de semana");
        }
        else
        {
            return BadRequest("el nombre del dia ingresado no es valido");
        }
    }
}
