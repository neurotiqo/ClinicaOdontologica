using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("recetas")]
    public class Receta
    {
        [Key]
        [Column("id_receta")]
        public int IdReceta { get; set; }

        [Required]
        [Column("fecha_emision", TypeName = "timestamp without time zone")]
        public DateTime FechaEmision { get; set; }

        [Required]
        [Column("indicaciones")]
        public string Indicaciones { get; set; } = string.Empty;

        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }

        // Objetos de Navegación
        public Cita? Cita { get; set; }
    }
}