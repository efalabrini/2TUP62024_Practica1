using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10 : ControllerBase
{   


    [HttpGet]
    public ActionResult Get(int inicio,int fin){

  if (fin - inicio < 1000)
        {
            return BadRequest("La diferencia tiene que ser mayor a mil");
        }

        List<int> listaPares=[];
        List<int> listaTodos=[];

        for(int i=0;i<=fin;i++){
            if(i%2==0){
                listaPares.Add(i);
            }
            listaTodos.Add(i);
        }
        List<int>[] retorno={listaPares,listaTodos};
        return Ok(retorno);
    }}
}
