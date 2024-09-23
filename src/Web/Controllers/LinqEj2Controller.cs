using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

    public class LinqEj2Controller : ControllerBase 
    {
    [HttpGet]    

        public ActionResult Get([FromQuery] List<string> wordList) 
        { 
            var wordQuery = 
                from word in wordList
                where (word.Length >= 5)
                select word.ToUpper();
            
        return Ok(wordQuery);
        }
    
    }

