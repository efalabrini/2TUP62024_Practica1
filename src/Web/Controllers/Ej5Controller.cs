using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public string Get(string dia)
    {
        string[] semana=["lunes","martes","miercoles","jueves","viernes","sabado","domingo"];
        bool fechaBienEscrita=false;
        dia=dia.Trim();

        for(int i=0;i<7;i++){
            fechaBienEscrita=String.Equals(dia,semana[i],StringComparison.OrdinalIgnoreCase);
            if(fechaBienEscrita) break;
    }
    if(!fechaBienEscrita){
        return "Fecha mal escrita";
    }
    if(String.Equals(dia,"domingo",StringComparison.OrdinalIgnoreCase)||String.Equals(dia,"sabado",StringComparison.OrdinalIgnoreCase)){
        return "Es fin de semana";
    }
    else{
        return "no es fin de semana";
    }
    
    }}
