
// 2) Pedir por parámetro un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) 
// y mostrar por consola el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>”. Utilizar Interpolación.

using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public string Ej3(){
        Console.WriteLine("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad: ");
        string edad = Console.ReadLine();




    
    return  $"Te llamas {nombre}, y tienes {edad} años.";

    }

}
