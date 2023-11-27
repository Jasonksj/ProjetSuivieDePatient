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
    public class AntecedentMedicaleControllers
    {
        AntecedentMedicaleService antecedentMedicaleService;

        public AntecedentMedicaleControllers()
        {
            antecedentMedicaleService = new AntecedentMedicaleService();
        }

        public Antecedentmedical Save(string TypeAntecedent, string Description, DateTime DateDiagnostic, string Statut, int PatientID)
        {
            Antecedentmedical antecedentmedical = new Antecedentmedical
            {
                TypeAntecedent = TypeAntecedent,
                Description = Description,
                DateDiagnostic = DateDiagnostic,
                Statut = Statut,
                PatientID = PatientID
            };
            return antecedentMedicaleService.Save(antecedentmedical);
        }

        public List<Antecedentmedical> FindAll()
        {
            return antecedentMedicaleService.FindAll();
        }

        public Antecedentmedical Update(Antecedentmedical antecedentmedical)
        {
            return antecedentMedicaleService.Update(antecedentmedical);
        }

        public int Delete(int id)
        {
            return antecedentMedicaleService.Delete(id);
        }

        public bool Exists(int id)
        {
            return antecedentMedicaleService.Exists(id);
        }

        public Antecedentmedical FindById(int id)
        {
            return antecedentMedicaleService.FindById(id);
        }

        public int PatientID()
        {
            return antecedentMedicaleService.PatientID();
        }
    }
}
