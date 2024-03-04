using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

    [ApiController]
    [Route("[controller]")]
    public class PromedioNotasController : ControllerBase
    {
        [HttpPost("calcularPromedio")]
        public ActionResult CalcularPromedio(promedioNotasModel notas)
        {
                double nota1 = double.Parse(notas.Nota1);
                double nota2 = double.Parse(notas.Nota2);
                double nota3 = double.Parse(notas.Nota3);
                double examenParcial = double.Parse(notas.ExamenParcial);
                double trabajoFinal = double.Parse(notas.TrabajoFinal);

                double promedio = (nota1 + nota2 + nota3) / 3.0;
                double puntajeFinal = promedio * 0.55;
                double puntajeExamen = examenParcial * 0.3;
                double puntajeTrabajoFinal = trabajoFinal * 0.15;
                double notaFinal = puntajeFinal + puntajeExamen + puntajeTrabajoFinal;

                return Ok("El promedio total de sus notas es de: " + notaFinal);

        }
    }
