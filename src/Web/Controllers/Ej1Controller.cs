using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
  [HttpGet()]
  public int Get( int num1, int num2, int num3)
  {
    int suma = num1 + num2 + num3;
    return suma;
  }
}
