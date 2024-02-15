using Microsoft.AspNetCore.Mvc;

namespace promedioNotas.Controllers
{
    public class PromedioNotasController : ControllerBase
    {
        [HttpGet ("calcular Promedio")]
        public IActionResult calcularPromedio(int Nota1, int Nota2, int Nota3, int ExamenParcial, int TrabajoFinal)
        {
            if (Nota1 < 10 || Nota1 > 50 ||
                Nota2 < 10 || Nota2 > 50 ||
                Nota3 < 10 || Nota3 > 50 ||
                ExamenParcial < 10 || ExamenParcial > 50 ||
                TrabajoFinal < 10 || TrabajoFinal > 50)
            {
                return BadRequest("Las notas deben estar entre 10 y 50.");
            }
            double promedio = (Nota1 + Nota2 + Nota3) / 3.0;
            double puntajeFinal = promedio * 0.55;
            double puntajeExamen = ExamenParcial * 0.3;
            double puntajeTrabajoFinal = TrabajoFinal * 0.15;
            double notaFinal = puntajeFinal + puntajeExamen + puntajeTrabajoFinal;

            return Ok(notaFinal);
        }
    }
}
