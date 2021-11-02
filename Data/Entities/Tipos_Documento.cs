using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Tipos_Documento
    {
        [Key]
        public string Codigo { get; set; }

        [StringLength(20)]
        public string Nombre { get; set; }

        [StringLength(5)]
        public string Abreviatura { get; set; }


        public ICollection<Clientes> Clientes { get; set; }
        public ICollection<Mecanicos> Mecanicos { get; set; }
    }
}
