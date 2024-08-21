using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ9Webapi : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerarListaPares(int inicio, int fin)
        {
            // Verificar que la diferencia entre inicio y fin sea menor a 1000
            if (fin - inicio >= 1000)
            {
                return BadRequest("La diferencia entre el número de inicio y fin debe ser menor a 1000.");
            }

            // Crear una lista para almacenar los números pares
            var numerosPares = new List<int>();

            // Usar un bucle while para generar la lista de números pares
            int i = inicio;
            while (i <= fin)
            {
                // Verificar si el número es par
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
                i++;
            }

            // Retornar la lista de números pares como una respuesta JSON
            return Ok(numerosPares);
        }
    }
}
