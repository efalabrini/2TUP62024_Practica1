using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EJ10Webapi : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerarListas(int inicio, int fin)
        {
            // Verificar que la diferencia entre inicio y fin sea menor a 1000
            if (fin - inicio >= 1000)
            {
                return BadRequest("La diferencia entre el número de inicio y fin debe ser menor a 1000.");
            }

            // Crear listas para almacenar los números pares e impares
            var numerosPares = new List<int>();
            var numerosImpares = new List<int>();

            // Usar un bucle while para generar las listas de números pares e impares
            int i = inicio;
            while (i <= fin)
            {
                // Verificar si el número es par o impar y añadirlo a la lista correspondiente
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
                else
                {
                    numerosImpares.Add(i);
                }
                i++;
            }

            // Crear un objeto para la respuesta
            var resultado = new
            {
                Pares = numerosPares,
                Impares = numerosImpares
            };

            // Retornar el objeto como una respuesta JSON
            return Ok(resultado);
        }
    }
}
