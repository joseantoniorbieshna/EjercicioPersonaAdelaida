using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionPersona.Models
{
    public class Direccion{
        [Required]
        [Key]
        public int CodigoDireccion { get; set; }
        public string Calle { get; set; }
        public Persona Persona { get; set; }
    }
}