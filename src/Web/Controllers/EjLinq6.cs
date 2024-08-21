﻿using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web;

[ApiController]
[Route("[controller]")]
public class EjLinq6 : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {

        var wordQuery = from word in words

                        select word.Replace("ia", "*");


        return Ok(wordQuery);
    }

}