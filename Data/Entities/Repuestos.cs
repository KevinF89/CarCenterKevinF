using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Repuestos
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(100)]
        public string Nombre_Repuesto { get; set; }
        public Nullable<decimal> Precio_Unitario { get; set; }
        public Nullable<int> Unidades_Inventario { get; set; }

        [StringLength(200)]
        public string Proveedor { get; set; }

        public ICollection<Repuestos_X_Mantenimientos> Repuestos_X_Mantenimientos { get; set; }
    }
}
