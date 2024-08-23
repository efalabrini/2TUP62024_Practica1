using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int numeroI, int numeroF)
    {
        if (Math.Abs(numeroF - numeroI) >= 1000)
        {
            return BadRequest("La diferencia entre los numeros de inicio y fin debe ser menor a 1000");
        }

        List<int> numeros = GenerarLista(numeroI, numeroF);

        return Ok(numeros);
    }

    private List<int> GenerarLista(int inicio, int fin)
    {
        List<int> lista = new List<int>();

        for (int i = inicio; i <= fin; i++)
        {
            lista.Add(i);
        }

        return lista;
    }
}