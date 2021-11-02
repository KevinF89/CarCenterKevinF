using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Presupuesto_X_Mantenimiento
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(6)]
        public string Cod_Placa { get; set; }
        public int Cod_Mantenimiento { get; set; }
        public decimal Presupuesto { get; set; }

        [ForeignKey("Cod_Mantenimiento")]
        public Mantenimientos Mantenimientos { get; set; }

        [ForeignKey("Cod_Placa")]
        public Vehiculos Vehiculos { get; set; }
    }
}
