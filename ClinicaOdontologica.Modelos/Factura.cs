using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura")]
        public int IdFactura { get; set; }

        [Required]
        [Column("fecha_emision", TypeName = "timestamp without time zone")]
        public DateTime FechaEmision { get; set; }

        [Required]
        [Column("subtotal", TypeName = "numeric(10,2)")]
        public decimal Subtotal { get; set; }

        [Required]
        [Column("impuestos", TypeName = "numeric(10,2)")]
        public decimal Impuestos { get; set; }

        [Required]
        [Column("total", TypeName = "numeric(10,2)")]
        public decimal Total { get; set; }

        [Column("estado_pago")]
        [MaxLength(20)]
        public string? EstadoPago { get; set; }

        [ForeignKey("Cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }

        // Objetos de Navegación
        public Cita? Cita { get; set; }
    }
}