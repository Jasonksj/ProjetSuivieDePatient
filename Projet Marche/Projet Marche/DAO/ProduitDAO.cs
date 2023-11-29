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
    public class ProduitDAO
    {
        MarchesEntities marchesEntities;
        Produit produit;

        public ProduitDAO()
        {
            marchesEntities = new MarchesEntities();
            produit = new Produit();
        }

        public Produit Save(Produit produit)
        {
            try
            {
                this.produit = produit;
                marchesEntities.Produits.Add(this.produit);
                marchesEntities.SaveChanges();
                return this.produit;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du produit '{this.produit.NomProduit}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Produit> FindAll()
        {
            try
            {
                return marchesEntities.Produits.ToList();
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
                produit = marchesEntities.Produits.FirstOrDefault
                    (
                        rendezvous => rendezvous.ProduitID == id
                    );
                marchesEntities.Produits.Remove(produit);
                marchesEntities.SaveChanges();
                return produit.ProduitID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du produit '{this.produit.NomProduit}'!\nErreur : {ex.Message}",
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
                return marchesEntities.Produits.SingleOrDefault(produit => produit.ProduitID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Produit Update(Produit produit)
        {
            try
            {
                this.produit = produit;
                marchesEntities.Produits.AddOrUpdate(this.produit);
                marchesEntities.SaveChanges();
                return this.produit;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du produit '{this.produit.NomProduit}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
