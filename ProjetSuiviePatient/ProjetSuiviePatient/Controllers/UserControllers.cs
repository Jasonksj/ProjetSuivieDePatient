using ProjetSuiviePatient.Entities;
using ProjetSuiviePatient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.Controllers
{
    public class UserControllers
    {
        UserService userService;

        public UserControllers()
        {
            userService = new UserService();
        }

        public Utilisateur Save(string username, string password)
        {
            Utilisateur utilisateur = new Utilisateur
            {
                NomUtilisateur = username,
                MotDePasse = password
            };
            return userService.Save(utilisateur);
        }

        public List<Utilisateur> FindAll()
        {
            return userService.FindAll();
        }

        public bool Exists(int id)
        {
            return userService.Exists(id);
        }

        public bool Exists(string name)
        {
            return userService.Exists(name);
        }

        public bool Exists(string username, string password)
        {
            return userService.Exists(username, password);
        }
    }
}
