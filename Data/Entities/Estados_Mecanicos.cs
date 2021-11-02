using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Estados_Mecanicos
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(20)]
        public string Nombre_Estado { get; set; }

        public ICollection<Mecanicos> Mecanicos { get; set; }
    }
}
