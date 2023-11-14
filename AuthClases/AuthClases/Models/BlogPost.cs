using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthClases.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [StringLength(100)]
        public string Autor { get; set; }
        public DateTime publicacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}