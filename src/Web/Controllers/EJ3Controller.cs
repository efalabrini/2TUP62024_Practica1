﻿using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class EJ3Controller:ControllerBase
{
    [HttpGet]
    public string Get(string nombre , string edad)
    {

        return $"te llamas {nombre}, y tienes {edad} años";

    }
}
