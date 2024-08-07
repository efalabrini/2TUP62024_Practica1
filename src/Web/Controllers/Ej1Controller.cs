
using Microsoft.AspNetCore.Mvc;

namespace Web;


[ApiController]
[Route("[controller]")]

public class Ej1Controller : ControllerBase {

    [HttpGet]
    public int Get(int a,int b,int c) {
        return a + b + c;
    }
} 