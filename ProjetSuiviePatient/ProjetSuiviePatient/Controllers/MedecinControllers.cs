using ProjetSuiviePatient.Entities;
using ProjetSuiviePatient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.Controllers
{
    public class MedecinControllers
    {
        MedecinService medecinService;

        public MedecinControllers()
        {
            medecinService = new MedecinService();
        }

        public Medecin Save(string Nom, string Prenom, string Specialite, string Telephone, string Email, 
                            int AnneesExperience, string Certifications, string Disponibilite)
        {
            Medecin medecin = new Medecin
            {
                Nom = Nom,
                Prenom = Prenom,
                Specialite = Specialite,
                Telephone = Telephone,
                Email = Email,
                AnneesExperience = AnneesExperience,
                Certifications = Certifications,
                Disponibilite = Disponibilite
            };
            return medecinService.Save(medecin);
        }

        public List<Medecin> FindAll()
        {
            return medecinService.FindAll();
        }

        public Medecin Update(Medecin medecin)
        {
            return medecinService.Update(medecin);
        }

        public int Delete(int id)
        {
            return medecinService.Delete(id);
        }

        public bool Exists(int id)
        {
            return medecinService.Exists(id);
        }

        public bool Exists(string name)
        {
            return medecinService.Exists(name);
        }

        public Medecin FindByName(string name)
        {
            return medecinService.FindByName(name);
        }

        public Medecin FindById(int id)
        {
            return medecinService.FindById(id);
        }

        public List<Medecin> FilterByName(string name)
        {
            return medecinService.FilterByName(name);
        }
    }
}
