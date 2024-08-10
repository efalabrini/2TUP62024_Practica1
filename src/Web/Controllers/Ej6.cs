using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6 : ControllerBase
    {
        [HttpGet]
        public float Get(float precio, int cantidad, string formaPago, int numTarjeta)
        {
            if (precio < 0 || cantidad < 0)
            {
                throw new Exception("Datos incorrectos");
            }
            formaPago = formaPago.ToLower().Trim();
            if (!(String.Equals(formaPago, "tarjeta") || String.Equals(formaPago, "efectivo")))
            {
                throw new Exception("Dato Incorrecto");
            }
            switch (formaPago)
            {
                case "tarjeta":
                    {

                        if (numTarjeta.ToString().Length != 16)
                        {
                            throw new Exception("Cantidad de digitos incorrecta");
                        }
                        return precio * cantidad * 0.10f;
                    }
                    break;
                case "efectivo":
                    {
                        return precio * cantidad;
                    }
                    break;
                default:
                    break;
            }
            return 0;
        }
    }
}
