using System.ComponentModel.DataAnnotations;

namespace F1Blazor2.Models
{
    public class CarreraDTO
    {

        [Required(ErrorMessage = "El nombre es requerido")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
        public string Nombre { get; set; } = null!;

        public string Pais { get; set; } = null!;

        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public byte[]? Bandera { get; set; } = null!;

    }
    public class CrearCarreraDTO
    {

        [Required(ErrorMessage = "El nombre es requerido")]
        [RegularExpression("^[A-Za-z\\s]+$",ErrorMessage = "Solo se admiten caracteres alfabeticos")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El pais es requerido Ejemplo: ESP")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos en mayusculas Ejemplo: ESP")]
        [StringLength(3,ErrorMessage = "La nacionalidad se compone de tres caracteres Ejemplo: ESP ")]
        public string Pais { get; set; } = null!;

        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La bandera es requerido")]
        public byte[] Bandera { get; set; } = null!;

    }
    public class CarreraEnteraDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Pais { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public byte[]? Bandera { get; set; } = null!;

    }
    public class CarreraDTOUpdate
    {
        public string Nombre { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

    }

    public class CarrerasEnterasModeloDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Pais { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public string? Bandera { get; set; } = null!;

    }
}
