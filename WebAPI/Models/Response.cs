using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebAPI.Models
{
    public class Response<T>
    {
            public bool Valido { get; set; }

            public string Error { get; set; }

            public string Descripcion { get; set; }

            public T Data { get; set; }

    }
}