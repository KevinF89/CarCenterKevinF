using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Marcas
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(30)]
        public string Nombre_Marca { get; set; }

        public ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
