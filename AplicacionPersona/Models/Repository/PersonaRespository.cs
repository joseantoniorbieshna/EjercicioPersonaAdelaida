using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionPersona.Models.Repository
{
   
    public class PersonaRespository
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public PersonaRespository() { 
        }

        public List<Persona> getListPersonas()
        {
            return db.Persona.ToList();
        }

        public Persona getPersonaById(int? id) {
            return db.Persona.Include("Direcciones").FirstOrDefault(x=>x.Id==id);
        }
        public List<Direccion> getAllDireccionesByIdPersona(int id)
        {
            Persona persona = db.Persona.Include("Direcciones").FirstOrDefault(x=>x.Id==id);
            return persona.Direcciones.ToList();
        }


    }
}