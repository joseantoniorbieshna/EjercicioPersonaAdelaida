using AplicacionPersona.Models;
using AplicacionPersona.Models.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AplicacionPersona.Controllers
{
    public class PersonaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private PersonaRespository _repo = new PersonaRespository();
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> personasList = _repo.getListPersonas();
            return View(personasList);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            Persona personaDevolver = _repo.getPersonaById(id);

            return View(personaDevolver);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            try
            {
                if (persona.Nacimiento != null) {
                    DateTime fechaNacimiento = persona.Nacimiento;
                    double annos = (DateTime.Now - fechaNacimiento).TotalDays / 365;
                    persona.Edad= (int)Math.Floor(annos); ;
                }
                if (ModelState.IsValid) {
                    db.Persona.Add(persona);
                    db.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            Persona persona=_repo.getPersonaById(id);
            db.Persona.Attach(persona);
            return View(persona);
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(Persona persona)
        {
            if (persona.Nacimiento != null)
            {
                DateTime fechaNacimiento = persona.Nacimiento;
                double annos = (DateTime.Now - fechaNacimiento).TotalDays / 365;
                persona.Edad = (int)Math.Floor(annos); ;
            }
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(persona);
        }


        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Persona.Find(id);
            db.Persona.Attach(persona);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Persona/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Persona.Find(id);
            db.Persona.Remove(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
