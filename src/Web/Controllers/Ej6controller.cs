//6) Reciba el precio de un producto (valor positivo), la cantidad a comprar y la forma de pagar (efectivo o tarjeta).
//Si la forma de pago es mediante tarjeta, debe recibir también el número de la misma(inventado), verificar que sean 16 dígitos
//y retornar el valor a pagar con un 10% de recargo.
//Si la forma de pago es mediante efectivo, retorna el valor a pagar.
//Si la forma de pago no es tarjeta ni efectivo, debe retornar un status code del grupo de los 400.


using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(float precio,int cantidad,string formaDePago,double numTarjeta = 0)
    {
        float total;
        if (precio <= 0 || cantidad <= 0)
        {
            return BadRequest("Datos invalidos");
        }
        else
        {
            total = precio * cantidad;
        }

        formaDePago = formaDePago.Trim().ToLower();

        if (formaDePago == "tarjeta")
        {
            while (true)
            {
                
                string numTarjetaStr = numTarjeta.ToString();

                if (numTarjetaStr.Length != 16)
                {
                    return BadRequest("Ingreso un numero de tarjeta no valido");
                }
                else
                {
                    total = (float)(total * 1.10);
                    return Ok(total);            
                }
            }
        }
        else if (formaDePago == "efectivo")
        {
            return Ok(total);
        }
        else
        {
           return BadRequest("Ingresó un metodo de pago no valido");
        }
    }
}
