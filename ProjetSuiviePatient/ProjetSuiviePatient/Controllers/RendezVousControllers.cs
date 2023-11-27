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

        public RendezVousControllers()
        {
            rendezVousService = new RendezVousService();
        }

        public Rendezvou Save(DateTime DateHeure, int MedecinID, int PatientID, string Motif, string Statut, string Remarques, string Urgence)
        {
            Rendezvou rendezvous = new Rendezvou
            {
                DateHeure = DateHeure,
                MedecinID = MedecinID,
                PatientID = PatientID,
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

        public int PatientID()
        {
            return rendezVousService.PatientID();
        }

        public int MedecinID()
        {
            return rendezVousService.MedecinID();
        }
    }
}
