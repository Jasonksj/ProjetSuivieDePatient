using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.DAO
{
    public class UserDAO
    {
        PatientEntities patientEntities;
        Utilisateur utilisateur;

        public UserDAO()
        {
            patientEntities = new PatientEntities();
            utilisateur = new Utilisateur();
        }

        public List<Utilisateur> FindAll()
        {
            try
            {
                return patientEntities.Utilisateurs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }
    }
}
