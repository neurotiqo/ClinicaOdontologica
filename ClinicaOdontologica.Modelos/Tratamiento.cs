using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Modelos
{
    [Table("tratamientos")]
    public class Tratamiento
    {
        [Key]
        [Column("id_tratamiento")]
        public int IdTratamiento { get; set; }

        [Required]
        [Column("nombre_tratamiento")]
        [MaxLength(100)]
        public string NombreTratamiento { get; set; } = string.Empty;
        
        [Required]
        [Column("costo_base", TypeName = "numeric(10,2)")]
        public decimal CostoBase { get; set; }

        [Required]
        [Column("duracion_estimada_minutos")]
        public int DuracionEstimadaMinutos { get; set; }

        // Relacionamiento
        List<Tratamiento> Tratamientos { get; set; } = new List<Tratamiento>();
    }   
}