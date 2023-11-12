using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionPersona.Models;

namespace AplicacionPersona.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            //Persona persona = new Persona() { Id = 10, Nombre = "Fernanda",Nacimiento=new DateTime(1999,11,10) , Edad=20};
            //db.Persona.Add(persona);
            //db.Persona.Attach(persona);
            /*
            db.Direccion.Add(new Direccion() { CodigoDireccion=4,Calle="Calle Sevilla",Persona=persona});
            db.Direccion.Add(new Direccion() { CodigoDireccion = 5, Calle = "Calle Ramon", Persona = persona });
            db.Direccion.Add(new Direccion() { CodigoDireccion = 6, Calle = "Calle Zugasti", Persona = persona });
            */
            //db.SaveChanges();

            //var personaDevolver = db.Persona.Include("Direcciones").FirstOrDefault(x => x.Id==1);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}