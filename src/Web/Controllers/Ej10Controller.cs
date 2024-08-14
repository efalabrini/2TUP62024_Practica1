//Reciba un número entero de inicio y un número entero de fin.
//Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
//Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
//pero creando dos listas, una con los números pares y otra con los números impares.
//Retornar las dos listas.




using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int inicio, int final)
    {
        //inicializo una lista que es como un array pero que tiene metodos propios y ademas es dinamico :)
        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();

        int diferencia = final - inicio;

        if (diferencia >= 1000)
        {
            return BadRequest("La diferencia entre ambos numeros debe ser menor a 1000");
        }
        else
        {
            int i = inicio;
            while (true)
            {

                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
                else
                {
                    numerosImpares.Add(i);
                }

                i = i + 1;
                if (i > final)
                {
                    break;
                }
            }
            //como el return solo puede devolver un solo valor lo que hago es crear un objeto anonimo y en sus atributos guardo
            //las listas de los numeros pares e impares de esa manera logro retornar las dos listas en un solo objeto
            return Ok(new
            {
                Pares = numerosPares,
                Impares = numerosImpares
            });
        }
    }
}