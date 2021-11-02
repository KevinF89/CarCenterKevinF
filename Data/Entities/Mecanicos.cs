using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Mecanicos
    {
        [Key]
        [Column(Order = 1)]
        public string Tipo_Documento { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Documento { get; set; }

        [StringLength(30)]
        public string Primer_Nombre { get; set; }

        [StringLength(30)]
        public string Segundo_Nombre { get; set; }

        [StringLength(30)]
        public string Primer_Apellido { get; set; }

        [StringLength(30)]
        public string Segundo_Apellido { get; set; }

        [StringLength(10)]
        public string Celular { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        public Nullable<int> Estado { get; set; }

        [ForeignKey("Tipo_Documento")]
        public Tipos_Documento Tipos_Documento { get; set; }

        [ForeignKey("Estado")]
        public Estados_Mecanicos Estados_Mecanicos { get; set; }
        public ICollection<Mantenimientos> Mantenimientos { get; set; }

        public virtual string Nombre_Estado { get; set; }
    }
}
