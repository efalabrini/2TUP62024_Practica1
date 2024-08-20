﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] int startNum, [FromQuery] int endNum)
        {
            if (endNum - startNum >= 1000)
            {
                return BadRequest("La diferencioa entre inicio y fin debe ser menor a 1000");
            }

            List<int> numberList = new List<int>();

            while (startNum <= endNum)
            {
                if (startNum % 2 == 0)
                {
                    numberList.Add(startNum);
                }
                startNum++;
            }

            return Ok(numberList);
        }
    }
}
}
