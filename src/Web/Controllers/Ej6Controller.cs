using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet("Pago")]
    public IActionResult Pago(float precio, int cantidad, string medio, string? nroTarjeta = null)
    {
        if (precio <= 0)
        {
            return BadRequest("El precio debe ser positivo.");
        }
        if (cantidad <= 0)
        {
            return BadRequest("La cantidad debe ser positiva.");
        }
        double total = precio * cantidad;
        
        switch(medio.ToLower())
        {
            case "tarjeta":
                if (nroTarjeta != null && nroTarjeta.Length == 16)
                {
                    double totalConRecargo = total * 1.10;
                    return Ok(totalConRecargo);
                }
                else {return BadRequest("El número de tarjeta debe tener 16 dígitos.");}
            case "efectivo":
                return Ok(total);
            default:
                return BadRequest("La forma de pago debe ser 'tarjeta' o 'efectivo'.");
                
        }

    }
}
