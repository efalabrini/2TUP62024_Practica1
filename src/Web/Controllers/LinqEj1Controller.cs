using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    [HttpGet]
    public ActionResult<List<int>> Filtro([FromQuery] List<int> lista,[FromQuery] int minimo,[FromQuery] int maximo)
    {
        var numerosFiltrados = lista.Where(n => n >= minimo && n <= maximo).ToList();
        return Ok(numerosFiltrados);
    }
}
