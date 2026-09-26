using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologica.Modelos
{
    [Table("especialidades")]
    public class Especialidad
    {
        [Key]
        [Column("id_especialidad")]
        public int IdEspecialidad { get; set; }

        [Required]
        [Column("nombre_especialidad")]
        [MaxLength(50)]
        public string NombreEspecialidad { get; set; } = string.Empty;

        [Column("descripcion")]
        [MaxLength(200)]
        public string? Descripcion { get; set; }

        // Relacionamiento
        public List<Especialidad> Especialidades { get; set; } = new List<Especialidad>();
    }
}