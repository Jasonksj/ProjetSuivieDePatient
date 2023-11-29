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
    public class FournisseurDAO
    {
        MarchesEntities marchesEntities;
        Fournisseur fournisseur;

        public FournisseurDAO()
        {
            marchesEntities = new MarchesEntities();
        }

        public Fournisseur Save(Fournisseur fournisseur)
        {
            try
            {
                this.fournisseur = fournisseur;
                marchesEntities.Fournisseurs.Add(this.fournisseur);
                marchesEntities.SaveChanges();
                return this.fournisseur;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du fournisseur '{this.fournisseur.NomFournisseur}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Fournisseur> FindAll()
        {
            try
            {
                return marchesEntities.Fournisseurs.ToList();
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
                fournisseur = marchesEntities.Fournisseurs.FirstOrDefault
                    (
                        fournisseur => fournisseur.FournisseurID == id
                    );
                marchesEntities.Fournisseurs.Remove(fournisseur);
                marchesEntities.SaveChanges();
                return fournisseur.FournisseurID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du fournisseur '{this.fournisseur.NomFournisseur}'!\nErreur : {ex.Message}",
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
                return marchesEntities.Fournisseurs.SingleOrDefault(fournisseur => fournisseur.FournisseurID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Fournisseur Update(Fournisseur fournisseur)
        {
            try
            {
                this.fournisseur = fournisseur;
                marchesEntities.Fournisseurs.AddOrUpdate(this.fournisseur);
                marchesEntities.SaveChanges();
                return this.fournisseur;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du fournisseur '{this.fournisseur.NomFournisseur}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
