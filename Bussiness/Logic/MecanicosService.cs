using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Business.Logic
{
    public class MecanicosService
    {
        private Context context = new Context();


        public bool CreateMecanico(Mecanicos mecanicos)
        {
            try 
            { 
                this.context.Database.ExecuteSqlCommand("SP_INSERT_MECANICO @TipoDocumento, @Documento, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Celular, @Direccion, @Email",
                new SqlParameter("@TipoDocumento", mecanicos.Tipo_Documento),
                new SqlParameter("@Documento", mecanicos.Documento),
                 new SqlParameter("@PrimerNombre", mecanicos.Primer_Nombre),
                new SqlParameter("@SegundoNombre", mecanicos.Segundo_Nombre),
                new SqlParameter("@PrimerApellido", mecanicos.Primer_Apellido),
                 new SqlParameter("@SegundoApellido", mecanicos.Segundo_Apellido),
                 new SqlParameter("@Celular", mecanicos.Celular),
                new SqlParameter("@Direccion", mecanicos.Direccion),
                new SqlParameter("@Email", mecanicos.Documento));

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Mecanicos> GetMecanicos()
        {
            List<Mecanicos> mecanicos = new List<Mecanicos>();
            try
            {
               mecanicos =  this.context.Database.SqlQuery<Mecanicos>("SP_SELECT_MECANICO").ToList();
                return mecanicos;
            }
            catch (Exception ex)
            {
                return mecanicos;
            }
        }

        public bool UpdateMecanico(Mecanicos mecanicos)
        {
            try
            {
                this.context.Database.ExecuteSqlCommand("SP_UPDATE_MECANICO @TipoDocumento, @Documento, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Celular, @Direccion, @Email, @EstadoMecanico",
                new SqlParameter("@TipoDocumento", mecanicos.Tipo_Documento),
                new SqlParameter("@Documento", mecanicos.Documento),
                 new SqlParameter("@PrimerNombre", mecanicos.Primer_Nombre),
                new SqlParameter("@SegundoNombre", mecanicos.Segundo_Nombre),
                new SqlParameter("@PrimerApellido", mecanicos.Primer_Apellido),
                 new SqlParameter("@SegundoApellido", mecanicos.Segundo_Apellido),
                 new SqlParameter("@Celular", mecanicos.Celular),
                new SqlParameter("@Direccion", mecanicos.Direccion),
                new SqlParameter("@Email", mecanicos.Documento),
                new SqlParameter("@EstadoMecanico",mecanicos.Estado));

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteMecanico(string tipoDocumento, int documento)
        {
            try
            {
                this.context.Database.ExecuteSqlCommand("SP_DELELETE_MECANICO @TipoDocumento, @Documento",
                new SqlParameter("@TipoDocumento", tipoDocumento),
                new SqlParameter("@Documento", documento));

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
