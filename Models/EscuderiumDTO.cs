using System.ComponentModel.DataAnnotations;

namespace F1Blazor2.Models
{
    //MOSTRAR ESCUDERIA SEGUN EL ID PROPORCIONADO (NO DEVUEVE ID)
    public class EscuderiumDTO
    {
        [Required(ErrorMessage = "El Nombre no puede ser nulo")]
        [MinLength(1, ErrorMessage = "El nombre tiene que tener almenos una letra")]
        [MaxLength(50, ErrorMessage = "El nombre tiene que tener menos cicuenta letra")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El Team Principal no puede ser nulo")]
        [MinLength(1, ErrorMessage = "El Team Principal tiene que tener almenos una letra")]
        [MaxLength(50, ErrorMessage = "El Team Principal tiene que tener menos cicuenta letra")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
        public string TeamPrincipal { get; set; } = null!;

        [Required(ErrorMessage = "La Nacionalidad no puede ser nula")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos en mayusculas Ejemplo: ESP")]
        [StringLength(3, ErrorMessage = "La nacionalidad se compone de tres caracteres Ejemplo: ESP ")]
        public string Nacionalidad { get; set; } = null!;

        [Required(ErrorMessage = "Adjunta un escudo")]
        public byte[]? Escudo { get; set; } = null!;

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int Victorias { get; set; }

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int Poles { get; set; }

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int Puntos { get; set; }

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int VueltasRapidas { get; set; }

    }

    //MOSTRAR TODAS LAS ESCUDERIAS CON ID

    public class EscuderiumEnteroDTO
    {

        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string TeamPrincipal { get; set; } = null!;

        public string Nacionalidad { get; set; } = null!;
        
        public byte[]? Escudo { get; set; } = null!;

        public int Victorias { get; set; }

        public int Poles { get; set; }

        public int Puntos { get; set; }

        public int VueltasRapidas { get; set; }
    }
    
    //MODELO PARA CREAR UNA ESCUDERIA
    public class    CrearEscuderiumDTO
    {
        [Required(ErrorMessage = "El Nombre no puede ser nulo")]
        [MinLength(1, ErrorMessage = "El nombre tiene que tener almenos una letra")]
        [MaxLength(50, ErrorMessage = "El nombre tiene que tener menos cicuenta letra")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El Team Principal no puede ser nulo")]
        [MinLength(1, ErrorMessage = "El Team Principal tiene que tener almenos una letra")]
        [MaxLength(50, ErrorMessage = "El Team Principal tiene que tener menos cicuenta letra")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
        public string TeamPrincipal { get; set; } = null!;

        [Required(ErrorMessage = "La Nacionalidad no puede ser nula")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos en mayusculas Ejemplo: ESP")]
        [StringLength(3, ErrorMessage = "La nacionalidad se compone de tres caracteres Ejemplo: ESP ")]
        public string Nacionalidad { get; set; } = null!;

        [Required(ErrorMessage = "Adjunta un escudo")]
        public byte[]? Escudo { get; set; } = null!;

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int Victorias { get; set; }

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int Poles { get; set; }

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int Puntos { get; set; }

        [Required(ErrorMessage = "No admite valores nulos")]
        [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
        public int VueltasRapidas { get; set; }

    }

    public class EscuderiumDTOUpdate 
    {
        public string Nombre { get; set; } = null!;

        public string TeamPrincipal { get; set; } = null!;

        public byte[] Escudo { get; set; } = null!;

        public int Victorias { get; set; }

        public int Poles { get; set; }

        public int Puntos { get; set; }

        public int VueltasRapidas { get; set; }
    }

    public class EscuderiumModeloEnteroDTO
    {

        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string TeamPrincipal { get; set; } = null!;

        public string Nacionalidad { get; set; } = null!;

        public string? Escudo { get; set; } = null!;

        public int Victorias { get; set; }

        public int Poles { get; set; }

        public int Puntos { get; set; }

        public int VueltasRapidas { get; set; }
    }
}
