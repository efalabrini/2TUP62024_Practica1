using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]

public class Ej4Controller : ControllerBase {
    [HttpGet]
    public int Get(int a, int b) {
        if (a > b) 
            return a;
        else
            return b;
    }
}