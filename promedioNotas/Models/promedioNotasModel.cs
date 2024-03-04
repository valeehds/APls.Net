using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class promedioNotasModel
{
    [Range(10, 50, ErrorMessage = "La nota 1 debe estar entre 10 y 50.")]
    [RegularExpression(@"^[0-9]+$", ErrorMessage = "La nota 1 debe ser un número entero.")]
    [DefaultValue("10")]
    [Required(ErrorMessage = "Este campo es obligatorio. Vuelva a intentarlo")]

    public string Nota1 { get; set; }

    [Range(10, 50, ErrorMessage = "La nota 2 debe estar entre 10 y 50.")]
    [RegularExpression(@"^[0-9]+$", ErrorMessage = "La nota 2 debe ser un número entero.")]
    [DefaultValue("20")]
    [Required(ErrorMessage = "Este campo es obligatorio. Vuelva a intentarlo")]

    public string Nota2 { get; set; }

    [Range(10, 50, ErrorMessage = "La nota 3 debe estar entre 10 y 50.")]
    [RegularExpression(@"^[0-9]+$", ErrorMessage = "La nota 3 debe ser un número entero.")]
    [DefaultValue("30")]
    [Required(ErrorMessage = "Este campo es obligatorio. Vuelva a intentarlo")]

    public string Nota3 { get; set; }

    [Range(10, 50, ErrorMessage = "El examen parcial debe estar entre 10 y 50.")]
    [RegularExpression(@"^[0-9]+$", ErrorMessage = "El examen parcial debe ser un número entero.")]
    [DefaultValue("40")]
    [Required(ErrorMessage = "Este campo es obligatorio. Vuelva a intentarlo")]

    public string ExamenParcial { get; set; }

    [Range(10, 50, ErrorMessage = "El trabajo final debe estar entre 10 y 50.")]
    [RegularExpression(@"^[0-9]+$", ErrorMessage = "El trabajo final debe ser un número entero.")]
    [DefaultValue("50")]
    [Required(ErrorMessage = "Este campo es obligatorio. Vuelva a intentarlo")]

    public string TrabajoFinal { get; set; }

}
