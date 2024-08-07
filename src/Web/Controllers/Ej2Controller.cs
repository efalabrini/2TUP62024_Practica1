using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class Ej2Controllers : ControllerBase{
    [HttpGet]
    public string Get(string name, string city){
        return $"Hola {name}, bienvenido a {city}.";
    }
}