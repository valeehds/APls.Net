using Microsoft.AspNetCore.Mvc;

namespace promedioNotas.Controllers
{
    public class sueldoController : ControllerBase
    {
        [HttpGet("calcularSueldo")]
        public IActionResult calcularSueldo(string nombre, int horasTrabajadas, int valorHora)
        {

            double totalSueldo = valorHora * horasTrabajadas;
            return Ok(nombre+ ", el valor a pagar de su sueldo corresponde a: "+totalSueldo);
        }
    }
}
