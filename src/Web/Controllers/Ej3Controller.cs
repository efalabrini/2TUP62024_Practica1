using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
	public string Get([FromQuery] string nombre, [FromQuery] int edad)
	{
		return $"Te llamas {nombre} y tenes {edad} años";
	}

}
