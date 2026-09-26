using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("consultorios")]
    public class Consultorio
    {
        [Key]
        [Column("id_consultorio")]
        public int IdConsultorio { get; set; }

        [Required]
        [Column("numero_sala")]
        [MaxLength(10)]
        public string Sala { get; set; } = string.Empty;

        [Required]
        [Column("piso")]
        public int Piso { get; set; }

        [Column("equipamiento_principal")]
        [MaxLength(100)]
        public string? EquipamientoPrincipal { get; set; }

        // Relacionamiento
        public List<Consultorio> Consultorios { get; set; } = new List<Consultorio>();
    }
}