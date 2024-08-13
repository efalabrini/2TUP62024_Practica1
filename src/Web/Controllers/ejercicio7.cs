// 7) Reciba un número entero de inicio y un número entero de fin.
// Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
// Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
// Usar un bucle for.


using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7Controllers : ControllerBase
{

    [HttpGet]
    public ActionResult Get(int first, int end)
    {
        var listNumber = new List<int> {};
        if(end - first > 1000){
            return StatusCode(400, "la diferencia entre inicio y fin debe ser menor a 1000.");
        }else{
            for (int i = first; i < end; i++)
            {
                listNumber.Add(i);
            }

            return Ok(listNumber);
        }
        

    }
}