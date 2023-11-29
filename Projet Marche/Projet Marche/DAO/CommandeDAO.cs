using Projet_Marche.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.DAO
{
    public class CommandeDAO
    {
        MarchesEntities marchesEntities;
        Commande commande;

        public CommandeDAO()
        {
            marchesEntities = new MarchesEntities();
            commande = new Commande();
        }

        public Commande Save(Commande commande)
        {
            try
            {
                this.commande = commande;
                marchesEntities.Commandes.Add(this.commande);
                marchesEntities.SaveChanges();
                return this.commande;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible de la commande numero '{this.commande.CommandeID}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Commande> FindAll()
        {
            try
            {
                return marchesEntities.Commandes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public int Delete(int id)
        {
            try
            {
                commande = marchesEntities.Commandes.FirstOrDefault
                    (
                        commande => commande.CommandeID == id
                    );
                marchesEntities.Commandes.Remove(commande);
                marchesEntities.SaveChanges();
                return commande.CommandeID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible de la commande numero '{this.commande.CommandeID}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return -1;
            }
        }

        public bool Exists(int id)
        {
            try
            {
                return marchesEntities.Commandes.SingleOrDefault(commande => commande.CommandeID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Commande Update(Commande commande)
        {
            try
            {
                this.commande = commande;
                marchesEntities.Commandes.AddOrUpdate(this.commande);
                marchesEntities.SaveChanges();
                return this.commande;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible de la commande numero '{this.commande.CommandeID}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null; 
            }
        }
    }
}
