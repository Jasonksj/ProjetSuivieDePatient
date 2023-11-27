using ProjetSuiviePatient.Entities;
using ProjetSuiviePatient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.Controllers
{
    public class MedicamentControllers
    {
        MedicamentService medicamentService;

        public MedicamentControllers()
        {
            medicamentService = new MedicamentService();
        }

        public Medicament Save(string NomMedicament, string Description, string Posologie, string FormeMedicament, string Fabricant)
        {
            Medicament medicament = new Medicament
            {
                NomMedicament = NomMedicament,
                Description = Description,
                Posologie = Posologie,
                FormeMedicament = FormeMedicament,
                Fabricant = Fabricant
            };
            return medicamentService.Save(medicament);
        }

        public List<Medicament> FindAll()
        {
            return medicamentService.FindAll();
        }

        public Medicament Update(Medicament medicament)
        {
            return medicamentService.Update(medicament);
        }

        public int Delete(int id)
        {
            return medicamentService.Delete(id);
        }

        public bool Exists(int id)
        {
            return medicamentService.Exists(id);
        }

        public bool Exists(string name)
        {
            return medicamentService.Exists(name);
        }

        public Medicament FindByName(string name)
        {
            return medicamentService.FindByName(name);
        }

        public Medicament FindById(int id)
        {
            return medicamentService.FindById(id);
        }

        public List<Medicament> FilterByName(string name)
        {
            return medicamentService.FilterByName(name);
        }
    }
}
