using Projet_Marche.DAO;
using Projet_Marche.Entities;
using Projet_Marche.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Marche.Controllers
{
    public class ProduitControllers
    {
        ProduitService produitService;
        public ProduitControllers()
        {
            produitService = new ProduitService();
        }

        public Produit Save(string NomProduit, Decimal prix, int stock)
        {
            Produit produit = new Produit
            {
                NomProduit = NomProduit,
                Prix = prix,
                Stock = stock
            };
            return produitService.Save(produit);
        }

        public List<Produit> FindAll()
        {
            return produitService.FindAll();
        }

        public Produit Update(Produit produit)
        {
            return produitService.Update(produit);
        }

        public int Delete(int id)
        {
            return produitService.Delete(id);
        }

        public bool Exists(int id)
        {
            return produitService.Exists(id);
        }

        public Produit FindById(int id)
        {
            return produitService.FindById(id);
        }

        public Produit FindByName(string name)
        {
            return produitService.FindByName(name);
        }

        public List<Produit> FilterByName(string name)
        {
            return produitService.FilterByName(name);
        }
    }
}
