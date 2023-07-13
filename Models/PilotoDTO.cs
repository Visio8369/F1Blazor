using System.ComponentModel.DataAnnotations;

namespace F1Blazor2.Models;
//DTO PARA DVOLVER PILOTO ESPECIFICO
public class PilotoDTO
{

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    [Required(ErrorMessage = "La Edad no puede ser nula")]
    [RegularExpression("^(1[8-9]|[2-5][0-9]|60)$", ErrorMessage = "Los pilotos tiene que tener de 18 a 60 años")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "Adjunta una foto")]
    public Byte[]? Foto { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int Poles { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int Victorias { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int VueltasRapidas { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int Puntos { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    public int? IdEscuderia { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    public int Dorsal { get; set; }

}

//DTO PARA CREAR EL PILOTO
public class CrearPilotoDTO
{
    [Required(ErrorMessage = "El Nombre no puede ser nulo")]
    [MinLength(1, ErrorMessage ="El nombre tiene que tener almenos una letra")]
    [MaxLength(50, ErrorMessage = "El nombre tiene que tener menos cicuenta letra")]
    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "El Apellido no puede ser nulo")]
    [MinLength(1, ErrorMessage = "El nombre tiene que tener almenos una letra")]
    [MaxLength(50, ErrorMessage = "El nombre tiene que tener menos cicuenta letra")]
    [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos")]
    public string Apellido { get; set; } = null!;

    [Required(ErrorMessage = "La Nacionalidad no puede ser nula")]
    [RegularExpression("^[A-Z]+$", ErrorMessage = "Solo se admiten caracteres alfabeticos en mayusculas Ejemplo: ESP")]
    [StringLength(3, ErrorMessage = "La nacionalidad se compone de tres caracteres Ejemplo: ESP ")]
    public string Nacionalidad { get; set; } = null!;

    [Required(ErrorMessage = "La Edad no puede ser nula")]
    [RegularExpression("^(1[8-9]|[2-5][0-9]|60)$", ErrorMessage = "Los pilotos tiene que tener de 18 a 60 años")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "Adjunta una foto")]
    public byte[]? Foto { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int Poles { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int Victorias { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int VueltasRapidas { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    [RegularExpression("^(0|[1-9]\\d*)$", ErrorMessage = "Solo se aceptan valores de 0 o mayor")]
    public int Puntos { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    public int? IdEscuderia { get; set; }

    [Required(ErrorMessage = "No admite valores nulos")]
    public int Dorsal { get; set; }

}

        //DTO PARA DEVOLVER TODOS LOS PILOTOS Y QUE SE VEA LA ID

    public class PilotoEnteroDTO 
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Nacionalidad { get; set; } = null!;

        public int Edad { get; set; }

        public byte[]? Foto { get; set; }

        public int Poles { get; set; }

        public int Victorias { get; set; }

        public int VueltasRapidas { get; set; }

        public int Puntos { get; set; }

        public int? IdEscuderia { get; set; }

        public int Dorsal { get; set; }
    }

    //DTO PARA ACTUALIZAR LOS CAMPOS ACTUALIZABLES
    public class PilotoToUpdateDTO
    {

        public int Edad { get; set; }

        public byte[]? Foto { get; set; }

        public int Poles { get; set; }

        public int Victorias { get; set; }

        public int VueltasRapidas { get; set; }

        public int Puntos { get; set; }

        public int? IdEscuderia { get; set; }

        public int Dorsal { get; set; }
    }

    public class PilotoEnteroModeloDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Nacionalidad { get; set; } = null!;

        public int Edad { get; set; }

        public string? Foto { get; set; }

        public int Poles { get; set; }

        public int Victorias { get; set; }

        public int VueltasRapidas { get; set; }

        public int Puntos { get; set; }

        public int? IdEscuderia { get; set; }

        public int Dorsal { get; set; }
    }

