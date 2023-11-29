using Projet_Marche.Entities;
using Projet_Marche.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Marche.Controllers
{
    public class CommandeControllers
    {
        CommandeService commandeService;
        Fournisseur fournisseur;
        Client client;
        March marche;

        public CommandeControllers()
        {
            commandeService = new CommandeService();
            fournisseur = new Fournisseur();
            client = new Client();
            marche = new March();
        }

        public Commande Save(DateTime DateCommande, Decimal MontantTotal, Fournisseur fournisseur, Client client, March marche)
        {
            Commande commande = new Commande
            {
                DateCommande = DateCommande,
                MontantTotal = MontantTotal,
                Fournisseur  = this.fournisseur,
                Client = this.client,
                March = this.marche

            };
            return commandeService.Save(commande);
        }

        public List<Commande> FindAll()
        {
            return commandeService.FindAll();
        }

        public Commande Update(Commande medecin)
        {
            return commandeService.Update(medecin);
        }

        public int Delete(int id)
        {
            return commandeService.Delete(id);
        }

        public bool Exists(int id)
        {
            return commandeService.Exists(id);
        }

        public Commande FindById(int id)
        {
            return commandeService.FindById(id);
        }

        public Commande FindByName(string name)
        {
            return commandeService.FindByName(name);
        }

        public List<Commande> FilterByName(string name)
        {
            return commandeService.FilterByName(name);
        }
    }
}
