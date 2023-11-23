using ProjetSuiviePatient.Entities;
using ProjetSuiviePatient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.Controllers
{
    public class PatientControllers
    {
        PatientService patientService;

        public PatientControllers()
        {
            patientService = new PatientService();
        }

        public Patient Save(string nom, string prenom, DateTime DateNaissance, string Sexe, string Adresse, string Telephone, string Email, DateTime DerniereVisite, string GroupeSanguin, string NumeroAssuranceMaladie, string CommentairesMedicaux)
        {
            Patient patient = new Patient
            {
                Nom = nom,
                Prenom = prenom,
                DateNaissance = DateNaissance,
                Sexe = Sexe,
                Adresse = Adresse,
                Telephone = Telephone,
                Email = Email,
                DerniereVisite = DerniereVisite,
                GroupeSanguin = GroupeSanguin,
                NumeroAssuranceMaladie = NumeroAssuranceMaladie,
                CommentairesMedicaux = CommentairesMedicaux
            };
            return patientService.Save(patient);
        }

        public List<Patient> FindAll()
        {
            return patientService.FindAll();
        }
    }
}
