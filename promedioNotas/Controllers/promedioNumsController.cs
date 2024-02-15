using Microsoft.AspNetCore.Mvc;

namespace promedioNotas.Controllers
{
    public class promedioNumsController : ControllerBase
    {
        [HttpGet ("Promedio Numeros")]
        public IActionResult promNums(int num1, int num2, int num3)
        {
            double prom = (num1 + num2 + num3) / 3;
            return Ok("El promedio de " + num1 + " + " + num2 + " + " + num3 + " es igual a: " + prom);
        }
    }
}
