using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class EditMecanicos
    {
        [Required]
        public string Tipo_Documento { get; set; }
        [Required]
        public int Documento { get; set; }
        [Required]
        public string Primer_Nombre { get; set; }
        [Required]
        public string Segundo_Nombre { get; set; }
        [Required]
        public string Primer_Apellido { get; set; }
        [Required]
        public string Segundo_Apellido { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Email { get; set; }
    }
}