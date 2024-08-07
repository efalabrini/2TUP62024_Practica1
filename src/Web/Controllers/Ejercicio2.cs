
// 2) Pedir por parámetro un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) 
// y mostrar por consola el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación.

using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public string Saludo(string nombre, string ciudad){

    
    return  $"Hola {nombre}, bienvenido a {ciudad}";

    }

}
