using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : Controller
    {
        [HttpGet("generar")]
        public IActionResult GenerarRango(
             int inicio,
             int fin)
        {
            if (fin - inicio >= 1000 || fin < inicio)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000 y fin debe ser mayor que inicio.");
            }

            List<int> numeros = [];
            for (int i = inicio; i <= fin; i++)
            {
                numeros.Add(i);
            }

            return Ok(numeros);
        }
    }
}
