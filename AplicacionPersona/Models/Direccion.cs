using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionPersona.Models
{
    public class Direccion{
        public int CodigoDireccion { get; set; }
        public string Calle { get; set; }
        public Persona Persona { get; set; }
    }
}