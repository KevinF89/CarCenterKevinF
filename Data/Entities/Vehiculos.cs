using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Vehiculos
    {
        [Key]
        [StringLength(6)]
        public string Placa { get; set; }

        [StringLength(30)]
        public string Color { get; set; }
        public Nullable<int> Cod_Marca { get; set; }
        public Nullable<int> Cli_Documento { get; set; }
        public string Cli_Tipo_Documento { get; set; }
        public Clientes Clientes { get; set; }

        [ForeignKey("Cod_Marca")]
        public Marcas Marcas { get; set; }
        public ICollection<Mantenimientos> Mantenimientos { get; set; }

        public ICollection<Presupuesto_X_Mantenimiento> Presupuesto_X_Mantenimiento { get; set; }
    }
}
