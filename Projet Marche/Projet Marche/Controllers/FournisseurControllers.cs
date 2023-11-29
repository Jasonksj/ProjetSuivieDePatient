using Projet_Marche.Entities;
using Projet_Marche.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Marche.Controllers
{
    public class FournisseurControllers
    {
        FournisseurService fournisseurService;

        public FournisseurControllers()
        {
            fournisseurService = new FournisseurService();
        }

        public Fournisseur Save(string NomFournisseur, string Adresse, string Email)
        {
            Fournisseur fournisseur = new Fournisseur
            {
                NomFournisseur = NomFournisseur,
                Adresse = Adresse,
                Email = Email
            };
            return fournisseurService.Save(fournisseur);
        }

        public List<Fournisseur> FindAll()
        {
            return fournisseurService.FindAll();
        }

        public Fournisseur Update(Fournisseur fournisseur)
        {
            return fournisseurService.Update(fournisseur);
        }

        public int Delete(int id)
        {
            return fournisseurService.Delete(id);
        }

        public bool Exists(int id)
        {
            return fournisseurService.Exists(id);
        }

        public bool Exists(string name)
        {
            return fournisseurService.Exists(name);
        }

        public Fournisseur FindByName(string name)
        {
            return fournisseurService.FindByName(name);
        }

        public Fournisseur FindById(int id)
        {
            return fournisseurService.FindById(id);
        }

        public List<Fournisseur> FilterByName(string name)
        {
            return fournisseurService.FilterByName(name);
        }
    }
}
