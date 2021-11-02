using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Servicios
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(100)]
        public string Nombre_Servicio { get; set; }
        public Nullable<decimal> Precio { get; set; }

        public ICollection<Servicios_X_Mantenimientos> Servicios_X_Mantenimientos { get; set; }
    }
}
