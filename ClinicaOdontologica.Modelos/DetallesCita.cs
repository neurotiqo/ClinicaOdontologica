using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("detallescita")]
    public class DetallesCita
    {
        [Key]
        [Column("id_detalles_cita")]
        public int IdDetallesCita { get; set; }

        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }

        [ForeignKey("Tratamiento")]
        [Column("id_tratamiento")]
        public int IdTratamiento { get; set; }

        [Required]
        [Column("costo_aplicado", TypeName = "numeric(10,2)")]
        public decimal CostoAplicado { get; set; }

        [Column("observaciones")]
        public string? Observaciones { get; set; }

        // Objetos de Navegación
        public Cita? Cita { get; set; }
        public Tratamiento? Tratamiento { get; set; }
    }
}