﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej2Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromQuery] string nombre, [FromQuery] string ciudad)
        {
            string mensaje = $"Hola {nombre}, bienvenido a {ciudad}.";
            return Ok(mensaje);
        }
    }
}