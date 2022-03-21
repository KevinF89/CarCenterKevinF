using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Bussiness.Logic
{
    public class ClientesService
    {
        private Context context = new Context();

        public List<Clientes> GetClientes(int? documento = null, string nombre = null)
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                IQueryable<Clientes> query = context.Set<Clientes>();

                if (documento.HasValue)
                {
                    query = query.Where(w => w.Documento.Equals(documento.Value));
                }

                if (!string.IsNullOrEmpty(nombre))
                {
                    query = query.Where(w => w.Primer_Nombre.Contains(nombre));
                }

                clientes = query.OrderBy(ob => ob.Primer_Nombre).ToList();
                return clientes;

            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
    }
}
