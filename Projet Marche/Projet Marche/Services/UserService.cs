using Projet_Marche.DAO;
using Projet_Marche.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.Services
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
                if (!Exists(utilisateur.Nom))
                    return userDAO.Save(utilisateur);
                else
                {
                    MessageBox.Show
                        (
                            $"Le nom '{utilisateur.Nom} existe déjà !",
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
                        user => user.Nom == username && user.MotdePasse == password
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
                        user => user.Nom == username
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
