using ProjetSuiviePatient.DAO;
using ProjetSuiviePatient.Entities;
using ProjetSuiviePatient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.Controllers
{
    public class RendezVousControllers
    {
        RendezVousService rendezVousService;
        Patient Patient;
        Medecin Medecin;
        public RendezVousControllers()
        {
            rendezVousService = new RendezVousService();
            Patient = new Patient();
            Medecin = new Medecin();
        }

        public Rendezvou Save(DateTime DateHeure, Medecin medecin, Patient patient, string Motif, string Statut, string Remarques, string Urgence)
        {
            Rendezvou rendezvous = new Rendezvou
            {
                DateHeure = DateHeure,
                Medecin = Medecin,
                Patient = Patient,
                Motif = Motif,
                Statut = Statut,
                Remarques = Remarques,
                Urgence = Urgence
            };
            return rendezVousService.Save(rendezvous);
        }

        public List<Rendezvou> FindAll()
        {
            return rendezVousService.FindAll();
        }

        public Rendezvou Update(Rendezvou rendezvous)
        {
            return rendezVousService.Update(rendezvous);
        }

        public int Delete(int id)
        {
            return rendezVousService.Delete(id);
        }

        public bool Exists(int id)
        {
            return rendezVousService.Exists(id);
        }

        public Rendezvou FindById(int id)
        {
            return rendezVousService.FindById(id);
        }

        public Rendezvou FindByName(string name)
        {
            return rendezVousService.FindByName(name);
        }

        public List<Rendezvou> FilterByName(string name)
        {
            return rendezVousService.FilterByName(name);
        }
    }
}
