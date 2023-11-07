using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AplicacionPersona.Models
{
    public class ApplicationDbContext : DbContext
    {
 

        public ApplicationDbContext(): base("DefaultConnection"){
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime"));
            modelBuilder.Properties<int>().Where(p => p.Name.StartsWith("Codigo")).Configure(p => p.IsKey());
            modelBuilder.Entity<Direccion>().HasRequired(x => x.Persona);


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Persona> Persona { get; set; }
        public DbSet<Direccion> Direccion { get; set; }


        public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }

}