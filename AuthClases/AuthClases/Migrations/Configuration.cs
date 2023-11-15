namespace AuthClases.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthClases.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AuthClases.Models.ApplicationDbContext";
        }

        protected override void Seed(AuthClases.Models.ApplicationDbContext context)
        {
            //Este método se ejecuta cada vez que ejecutamos el comando update-database
            /*
            context.Comentarios.AddOrUpdate(x => x.Id, new Models.Comentario()
            {
                Id = 1,
                Autor = "Pablo",
                BlogPostId = 1,
                Contenido = "Contenidoooooooo"
            });
            */
        }
    }
}
