using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Facturas
    {
        [Key]
        public int Codigo { get; set; }
        public Nullable<decimal> Valor_Total { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<int> Cod_Mantenimiento { get; set; }

        public Nullable<int> Cli_Documento { get; set; }

        [StringLength(2)]
        public string Cli_Tipo_Documento { get; set; }

        public Clientes Clientes { get; set; }


        [ForeignKey("Cod_Mantenimiento")]
        public Mantenimientos Mantenimientos { get; set; }
    }
}
