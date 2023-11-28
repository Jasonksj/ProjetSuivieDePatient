using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Utilisateur Save(Utilisateur utilisateur)
        {
            try
            {
                this.utilisateur = utilisateur;
                patientEntities.Utilisateurs.Add(this.utilisateur);
                patientEntities.SaveChanges();
                return this.utilisateur;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible de l'analyse medicale du medecin '{this.utilisateur.NomUtilisateur}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public bool Exists(int id)
        {
            try
            {
                return patientEntities.Utilisateurs.SingleOrDefault(utilisateur => utilisateur.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }
    }
}
