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
    public class AnalyseMedicaleControllers
    {
        AnalyseMedicaleService analyseMedicaleService;
        Patient patient;
        Medecin medecin;

        public AnalyseMedicaleControllers()
        {
            analyseMedicaleService = new AnalyseMedicaleService();
            patient = new Patient();
            medecin = new Medecin();
        }

        public Analysemedicale Save(DateTime DateAnalyse, string TypeAnalyse, string Resultats, string Laboratoire,
            string CommentairesResultats, Medecin Medecin, Patient Patient)
        {
            Analysemedicale analysemedicale = new Analysemedicale
            {
                DateAnalyse = DateAnalyse,
                TypeAnalyse = TypeAnalyse,
                Resultats = Resultats,
                Laboratoire = Laboratoire,
                CommentairesResultats = CommentairesResultats,
                Medecin = medecin,
                Patient = patient
            };
            return analyseMedicaleService.Save(analysemedicale);
        }

        public List<Analysemedicale> FindAll()
        {
            return analyseMedicaleService.FindAll();
        }

        public Analysemedicale Update(Analysemedicale analysemedicale)
        {
            return analyseMedicaleService.Update(analysemedicale);
        }

        public int Delete(int id)
        {
            return analyseMedicaleService.Delete(id);
        }

        public bool Exists(int id)
        {
            return analyseMedicaleService.Exists(id);
        }

        public Analysemedicale FindById(int id)
        {
            return analyseMedicaleService.FindById(id);
        }

        public int MedecinID()
        {
            return analyseMedicaleService.MedecinID();
        }

        public int PatientID()
        {
            return analyseMedicaleService.PatientID();
        }

        public Analysemedicale FindByName(string name)
        {
            return analyseMedicaleService.FindByName(name);
        }

        public List<Analysemedicale> FilterByName(string name)
        {
            return analyseMedicaleService.FilterByName(name);
        }
    }
}
