using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthClases.Models
{
    public class BlogPostRepository
    {
        public List<BlogPost> ObtenerTodos()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.BlogPosts.Include("Comentarios").ToList();
            }
        }

        internal void Crear(BlogPost model)
        {
            using (var db = new ApplicationDbContext())
            {
                db.BlogPosts.Add(model);
                db.SaveChanges();
            }

        }

    }
}