using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [Required]
        [Column("dni")]
        [MaxLength(10)]
        public string Cedula { get; set; } = string.Empty;

        [Required]
        [Column("nombres")]
        [MaxLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [Column("apellidos")]
        [MaxLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        [Column("fecha_nacimiento", TypeName = "date")] 
        public DateOnly FechaNacimiento { get; set; }

        [Required]
        [Column("email")]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Column("telefono")]
        [MaxLength(10)]
        public string? Telefono { get; set; }

        // Relacionamiento
        List<Paciente> Pacientes { get; set; } = new List<Paciente>();
    }
}