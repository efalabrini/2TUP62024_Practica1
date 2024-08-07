using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public string Get(string dia)
        {
            // Quitar espacios en blanco al inicio y al final y convertir a minúsculas
            string diaNormalizado = dia.Trim();

            // Verificar si el día ingresado es fin de semana
            if (string.Equals(diaNormalizado, "sabado", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(diaNormalizado, "domingo", StringComparison.OrdinalIgnoreCase))
            {
                return $"{diaNormalizado} es fin de semana.";
            }
            // Verificar si el día ingresado es un día laborable
            else if (string.Equals(diaNormalizado, "lunes", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(diaNormalizado, "martes", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(diaNormalizado, "miercoles", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(diaNormalizado, "jueves", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(diaNormalizado, "viernes", StringComparison.OrdinalIgnoreCase))
            {
                return $"{diaNormalizado} no es fin de semana.";
            }
            // Manejar errores en el input
            else
            {
                return "Error: día ingresado no válido.";
            }
        }
    }
}
