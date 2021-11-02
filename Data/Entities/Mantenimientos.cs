using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Mantenimientos
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(6)]
        public string Cod_Placa { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }

        [StringLength(2)]
        public string Mec_Tipo_Documento { get; set; }
        public Nullable<int> Mec_Documento { get; set; }
        public Nullable<int> Estado { get; set; }

        [ForeignKey("Estado")]
        public  Estados_Mantenimiento Estados_Mantenimiento { get; set; }

        public Mecanicos Mecanicos { get; set; }

        [ForeignKey("Cod_Placa")]
        public  Vehiculos Vehiculos { get; set; }

        public ICollection<Facturas> Facturas { get; set; }
        public ICollection<Fotos> Fotos { get; set; }
        public  ICollection<Presupuesto_X_Mantenimiento> Presupuesto_X_Mantenimiento { get; set; }
        public  ICollection<Repuestos_X_Mantenimientos> Repuestos_X_Mantenimientos { get; set; }
        public  ICollection<Servicios_X_Mantenimientos> Servicios_X_Mantenimientos { get; set; }
    }
}
