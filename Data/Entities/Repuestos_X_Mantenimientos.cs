using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class Repuestos_X_Mantenimientos
    {
        [Key]
        public int Codigo { get; set; }
        public Nullable<int> Unidades { get; set; }
        public Nullable<int> Tiempo_Estimado { get; set; }
        public Nullable<int> Cod_Repuesto { get; set; }
        public Nullable<int> Cod_Mantenimiento { get; set; }

        [ForeignKey("Cod_Mantenimiento")]
        public Mantenimientos Mantenimientos { get; set; }

        [ForeignKey("Cod_Repuesto")]
        public Repuestos Repuestos { get; set; }
    }
}
