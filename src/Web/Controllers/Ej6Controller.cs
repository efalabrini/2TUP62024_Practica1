using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

using System.Diagnostics.Eventing.Reader;


namespace Web.Controllers

{
    [Route("api/[controller]")]
    [ApiController]

    public class Ej6Controller : ControllerBase

    {
        [HttpGet()]

        public String Get([FromQuery] double price, [FromQuery] string MethodPay, [FromQuery] string Card)

        {
            string Payment;

            if (price <= 0)
            {
                return "El valor debe ser mayor a 0";
            }

            if (MethodPay.Equals("Tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (Card.Length != 16)
                    return "La tarjeta debe tener 16 digitos en total";


                double FinalPrice = price * 1.10;
                Payment = $"El precio final al abonar con tarjeta es de {FinalPrice}";
                return Payment;
            }

            else if (MethodPay.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
            {
                Payment = $"El precio final en efectivo es de {price}";
                return Payment;
            }
            else
            {
                Payment = "ERROR, debe ser debito o efectivo";
                return Payment;
            }





        }
    }
}