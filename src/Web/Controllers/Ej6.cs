using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6 : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(float precio, int cantidad, string formaPago, string numTarjeta = "")
        {
            if (precio < 0 || cantidad < 0)
            {
                return BadRequest("Datos Incorrectos");
            }
            formaPago = formaPago.ToLower().Trim();
            if (!(String.Equals(formaPago, "tarjeta") || String.Equals(formaPago, "efectivo")))
            {
                return BadRequest("Datos Incorrectos");
            }
            switch (formaPago)
            {
                case "tarjeta":
                    {

                        if (numTarjeta.Length != 16)
                        {
                            return BadRequest("Datos Incorrectos");
                        }
                        return Ok(precio * cantidad * 1.10f);
                    }

                case "efectivo":
                    {
                        return Ok(precio * cantidad);
                    }

                default:return BadRequest("Datos Incorrectos");
                    
            }
            
            
        }
    }
}
