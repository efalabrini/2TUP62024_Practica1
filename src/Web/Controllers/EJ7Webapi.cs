using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ7Webapi : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerarLista(int inicio, int fin)
        {
            // Verificar que la diferencia entre inicio y fin sea menor a 1000
            if (fin - inicio >= 1000)
            {
                return BadRequest("La diferencia entre el número de inicio y fin debe ser menor a 1000.");
            }

            // Crear una lista para almacenar los números
            var numeros = new List<int>();

            // Usar un bucle for para generar la lista de números
            for (int i = inicio; i <= fin; i++)
            {
                numeros.Add(i);
            }

            // Retornar la lista como una respuesta JSON
            return Ok(numeros);
        }
    }
}
