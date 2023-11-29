using Projet_Marche.Entities;
using Projet_Marche.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Marche.Controllers
{
    public class DetailCommandeControllers
    {
        DetailCommandeService detailCommandeService;
        Commande commande;
        Produit produit;

        public DetailCommandeControllers()
        {
            detailCommandeService = new DetailCommandeService();
            commande = new Commande();
            produit = new Produit();
        }

        public DetailsCommande Save(Commande commande, Produit produit, int quantite, Decimal prix, Decimal montant)
        {
            DetailsCommande detailsCommande = new DetailsCommande
            {
                Commande = this.commande,
                Produit = this.produit,
                Quantite = quantite,
                PrixUnitaire = prix,
                MontantTotal = montant
            };
            return detailCommandeService.Save(detailsCommande);
        }

        public List<DetailsCommande> FindAll()
        {
            return detailCommandeService.FindAll();
        }

        public DetailsCommande Update(DetailsCommande detailsCommande)
        {
            return detailCommandeService.Update(detailsCommande);
        }

        public int Delete(int id)
        {
            return detailCommandeService.Delete(id);
        }

        public bool Exists(int id)
        {
            return detailCommandeService.Exists(id);
        }

        public DetailsCommande FindById(int id)
        {
            return detailCommandeService.FindById(id);
        }

        public DetailsCommande FindByName(string name)
        {
            return detailCommandeService.FindByName(name);
        }

        public List<DetailsCommande> FilterByName(string name)
        {
            return detailCommandeService.FilterByName(name);
        }
    }
}
