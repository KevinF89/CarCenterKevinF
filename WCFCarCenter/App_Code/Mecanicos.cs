using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Business.Logic;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Mecanicos : IMecanicos
{
    private MecanicosService mecanicosService = new MecanicosService();
    public List<TMecanicos> ConsultarMecanicos()
    {
        List<TMecanicos> Respuesta = new List<TMecanicos>();
        List<Data.Entities.Mecanicos> mecanicosList = new List<Data.Entities.Mecanicos>();


        try
        {
            mecanicosList = mecanicosService.GetMecanicos();

            foreach (Data.Entities.Mecanicos mecanico in mecanicosList)
            {
                Respuesta.Add(new TMecanicos
                {
                    Tipo_Documento = mecanico.Tipo_Documento,
                    Documento = mecanico.Documento,
                    Primer_Nombre = mecanico.Primer_Nombre,
                    Segundo_Nombre = mecanico.Segundo_Nombre,
                    Primer_Apellido = mecanico.Primer_Apellido,
                    Segundo_Apellido = mecanico.Segundo_Apellido,
                    Celular = mecanico.Celular,
                    Direccion = mecanico.Direccion,
                    Email = mecanico.Email,
                    Estado = mecanico.Nombre_Estado
                });
            }

        }
        catch (Exception ex)
        {

            //registro del error en auditoria no se alcanza a realizar
        }

        return Respuesta;

    }
}
