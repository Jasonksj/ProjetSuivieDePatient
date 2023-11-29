using Projet_Marche.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.DAO
{
    public class UserDAO
    {
        MarchesEntities marchesEntities;
        Utilisateur utilisateur;

        public UserDAO()
        {
            marchesEntities = new MarchesEntities();
            utilisateur = new Utilisateur();
        }

        public List<Utilisateur> FindAll()
        {
            try
            {
                return marchesEntities.Utilisateurs.ToList();
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
                marchesEntities.Utilisateurs.Add(this.utilisateur);
                marchesEntities.SaveChanges();
                return this.utilisateur;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible de l'analyse medicale du medecin '{this.utilisateur.Nom}'!\nErreur : {ex.Message}",
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
                return marchesEntities.Utilisateurs.SingleOrDefault(utilisateur => utilisateur.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }
    }
}
