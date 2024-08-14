using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet]

    public IActionResult Get(string day)
    {
        
    string[] daysWeek = ["lunes", "martes","miercoles", "jueves", "viernes"]; //arreglo de strings
    string[] daysWeekend =["sabado","domingo"];

    day = day.ToLower().Trim(); //Convierte el valor de day a minúsculas y elimina los espacios en blanco al inicio y al final para normalizar el input.

    if (daysWeek.Contains(day))
    {
        return BadRequest("Ese dia no pertenece al fin de la semana"); // badrequest es el error que tiene el cliente, aparece cuando el usuario se equivoca y pone otra cosa
    }
    else if (daysWeekend.Contains(day))
    {
        return Ok("Ese dia pertenece al fin de la semna"); // ok es que acepta, no devolver un status code.
    }
    return StatusCode(StatusCodes.Status500InternalServerError," Error: el dia ingresado no existe ");
    }

}

//hacer pull