using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita")]
        public int IdCita { get; set; }

        [Required]
        [Column("fecha_cita")]
        public DateOnly FechaCita { get; set; }

        [Column("motivo")]
        [MaxLength(200)]
        public string? Motivo { get; set; }

        [Column("estado_cita")]
        [MaxLength(20)]
        public string? EstadoCita { get; set; }

        [Required]
        [ForeignKey("Paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [Required]
        [ForeignKey("Odontologo")]
        [Column("id_odontologo")]
        public int IdOdontologo { get; set; }

        [Required]
        [ForeignKey("Consultorio")]
        [Column("id_consultorio")]
        public int IdConsultorio { get; set; }

        // Objetos de Navegación
        public Paciente? Paciente { get; set; }
        public Odontologo? Odontologo { get; set; }
        public Consultorio? Consultorio { get; set; }

        // Relacionamiento
        public List<Cita>  Citas { get; set; } = new List<Cita>();
    }
}