using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo")]
        public int IdOdontologo { get; set; }

        [Required]
        [Column("nombres")]
        [MaxLength(50)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [Column("apellidos")]
        [MaxLength(50)]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        [Column("registro_medico")]
        [MaxLength(20)]
        public string RegistroMedico { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Especialidad")]
        [Column("id_especialidad")]
        public int IdEspecialidad { get; set; }


        // Objetos de Navegación
        public Especialidad? Especialidad { get; set; }

        // Relacionamiento
        public List<Cita> Citas { get; set; } = new List<Cita>();
    }
}