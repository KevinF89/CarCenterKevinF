using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models.Mecanicos;

namespace WebAPI.MappingExtensions
{
    public static class Mecanicos
    {
        public static Data.Entities.Mecanicos ToEntity(this CreateMecanicos model)
        {
            Data.Entities.Mecanicos mecanicos = new Data.Entities.Mecanicos
            {
                Tipo_Documento = model.Tipo_Documento,
                Documento = model.Documento,
                Primer_Nombre = model.Primer_Nombre,
                Segundo_Nombre = model.Segundo_Nombre,
                Primer_Apellido = model.Primer_Apellido,
                Segundo_Apellido = model.Segundo_Apellido,
                Celular = model.Celular,
                Direccion = model.Direccion,
                Email = model.Email
            };

            return mecanicos;
        }

        public static Data.Entities.Mecanicos ToEntity(this UpdateMecanicos model)
        {
            Data.Entities.Mecanicos mecanicos = new Data.Entities.Mecanicos
            {
                Tipo_Documento = model.Tipo_Documento,
                Documento = model.Documento,
                Primer_Nombre = model.Primer_Nombre,
                Segundo_Nombre = model.Segundo_Nombre,
                Primer_Apellido = model.Primer_Apellido,
                Segundo_Apellido = model.Segundo_Apellido,
                Celular = model.Celular,
                Direccion = model.Direccion,
                Email = model.Email,
                Estado = model.Estado
            };

            return mecanicos;
        }
    }
}