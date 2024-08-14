using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej8Controllers : ControllerBase
{

    [HttpGet]
    public ActionResult Get(int first, int end)
    {
        var listNumber = new List<int> {};
        if(end - first > 1000){
            return StatusCode(400, "la diferencia entre inicio y fin debe ser menor a 1000.");
        }else{
            while (first <= end)
            {
                listNumber.Add(first);
                first++;
            }
            return Ok(listNumber);
        }


    }
}