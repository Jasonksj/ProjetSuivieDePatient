using ProjetSuiviePatient.DAO;
using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Services
{
    public class UserService
    {
        UserDAO userDAO;

        public UserService()
        {
            userDAO = new UserDAO();
        }

        public Utilisateur Save(Utilisateur utilisateur)
        {
            try
            {
                if (!Exists(utilisateur.NomUtilisateur))
                    return userDAO.Save(utilisateur);
                else
                {
                    MessageBox.Show
                        (
                            $"Le patient '{utilisateur.NomUtilisateur} existe déjà !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return userDAO.Exists(id);
        }

        public bool Exists(string username, string password)
        {
            try
            {
                List<Utilisateur> utilisateurs = FindAll();
                List<Utilisateur> foundUtilisateurs = utilisateurs.FindAll
                    (
                        user => user.NomUtilisateur == username && user.MotDePasse == password
                    );

                return foundUtilisateurs.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(string username)
        {
            try
            {
                List<Utilisateur> utilisateurs = FindAll();
                List<Utilisateur> foundUtilisateurs = utilisateurs.FindAll
                    (
                        user => user.NomUtilisateur == username
                    );

                return foundUtilisateurs.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Utilisateur> FindAll()
        {
            return userDAO.FindAll();
        }
    }
}
