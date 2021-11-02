using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Fotos
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(200)]
        public string Ruta { get; set; }

        public Nullable<int> Cod_Mantenimiento { get; set; }

        [ForeignKey("Cod_Mantenimiento")]
        public Mantenimientos Mantenimientos { get; set; }
    }
}
