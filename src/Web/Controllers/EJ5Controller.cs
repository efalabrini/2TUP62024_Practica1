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
                return BadRequest("El nombre del día no puede estar vacío.");
            }

            day = day.Trim();

            if (Enum.TryParse(day, true, out DayOfWeek parsedDay))
            {
                bool isWeekend = parsedDay == DayOfWeek.Saturday || parsedDay == DayOfWeek.Sunday;
                return Ok(isWeekend ? "Es fin de semana." : "No es fin de semana.");
            }
            else
            {
                return BadRequest("El nombre del día ingresado no es válido.");
            }
    }
}
