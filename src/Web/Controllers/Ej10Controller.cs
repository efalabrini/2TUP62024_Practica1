using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int numeroI, int numeroF)
    {
        if (Math.Abs(numeroF - numeroI) >= 1000)
        {
            return BadRequest("La diferencia entre los numeros de inicio y fin debe ser menor a 1000");
        }

        (List<int> pares, List<int> impares) = GenerarLista(numeroI, numeroF);

        var resultado = new
        {
            Pares = pares,
            Impares = impares
        };

        return Ok(resultado);
    }

    private (List<int> pares, List<int> impares) GenerarLista(int inicio, int fin)
    {
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                pares.Add(i);
            } else
            {
                impares.Add(i);
            }
        }

        return (pares, impares);
    }
}