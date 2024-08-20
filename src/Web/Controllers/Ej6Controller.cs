using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] double precio, [FromQuery] string formaPago, [FromQuery] string tarjeta = null )
        {
            string respuesta;

            if (precio < 0)
            {
                return "El Precio no puede ser menor que 0.";
            }

            if (formaPago.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (tarjeta == null || tarjeta.Length != 16)
                {
                    return "Ingrese una tarjeta valida, esta debe contener 16 digitos.";
                }

                double total = precio * 1.10;
                respuesta = $"El valor total a pagar con tarjeta es: {total}.";
                return respuesta;
            }
            else if (formaPago.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
                {
                respuesta = $"El valor total a pagar en efectivo es: {precio}.";
                return respuesta;
                }
            else
            {
                respuesta = "El metodo de pago no es valido, debe ingresar Tarjeta o Efectivo.";
                return respuesta;
            }
        }
    }
}