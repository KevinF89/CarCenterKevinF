using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Servicios_X_Mantenimientos
    {
        [Key]
        public int Codigo { get; set; }
        public Nullable<int> Tiempo_Estimado { get; set; }
        public Nullable<int> Cod_Servicio { get; set; }
        public Nullable<int> Cod_Mantenimiento { get; set; }

        [ForeignKey("Cod_Mantenimiento")]
        public Mantenimientos Mantenimientos { get; set; }

        [ForeignKey("Cod_Servicio")]
        public Servicios Servicios { get; set; }
    }
}
