using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string day)
        {
            try
            {
                day = day.Trim().ToLower();

                var weekdays = new List<string> { "lunes", "martes", "miércoles", "jueves", "viernes" };
                var weekends = new List<string> { "sábado", "domingo" };

                foreach (var weekday in weekdays)
                {
                    if (day == weekday)
                    {
                        return Ok("No es fin de semana.");
                    }
                }

                foreach (var weekend in weekends)
                {
                    if (day == weekend)
                    {
                        return Ok("Es fin de semana.");
                    }
                }

                return BadRequest("No ingresó un día válido.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
