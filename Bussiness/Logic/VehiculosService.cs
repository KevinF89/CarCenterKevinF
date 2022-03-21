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
    public class VehiculosService
    {
        private Context context = new Context();

        public List<Vehiculos> GetVehiculos(int? codMarca = null, string color = null, string placa = null)
        {
            List<Vehiculos> vehiculos = new List<Vehiculos>();
            try
            {
                IQueryable<Vehiculos> query = context.Set<Vehiculos>();

                if(codMarca.HasValue)
                {
                    query = query.Where(w => w.Cod_Marca.Equals(codMarca.Value));
                }

                if(!string.IsNullOrEmpty(color))
                {
                    query = query.Where(w => w.Color.Equals(color));
                }

                if(!string.IsNullOrEmpty(placa))
                {
                    query = query.Where(w => w.Placa.Equals(placa));
                }

                vehiculos = query.OrderBy(ob => ob.Placa).ToList();
                return vehiculos;

            }
            catch (Exception ex)
            {
                return vehiculos;
            }
        }
    }
}
