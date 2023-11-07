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
            Persona persona = new Persona() { Id = 1, Nombre = "Pepito",Nacimiento=new DateTime(2015,1,23) , Edad=10};
           // db.Persona.Add(persona);
            db.Persona.Attach(persona);
            /*
            db.Direccion.Add(new Direccion() { CodigoDireccion=1,Calle="Calle Federico",Persona=persona});
            db.Direccion.Add(new Direccion() { CodigoDireccion = 2, Calle = "Calle Mayo", Persona = persona });
            db.Direccion.Add(new Direccion() { CodigoDireccion = 2, Calle = "Calle Extrania", Persona = persona });
            */
            //db.SaveChanges();

            var personaDevolver = db.Persona.Include("Direcciones").FirstOrDefault(x => x.Id==1);

            return View(personaDevolver);
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