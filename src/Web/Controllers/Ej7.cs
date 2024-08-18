using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ej7 : ControllerBase
{

    [HttpGet]
    public ActionResult Get(int inicio, int fin)
    {
        if (fin - inicio < 1000)
        {
            return BadRequest("La diferencia tiene que ser mayor a mil");
        }
        List<int> list=new List<int>();
        for(int i = inicio; i <= fin; i++)
        {
            list.Add(i);
        }
        return Ok(list);
    }
}
