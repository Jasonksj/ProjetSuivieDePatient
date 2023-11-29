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
    public class DetailCommandeDAO
    {
        MarchesEntities marchesEntities;
        DetailsCommande detailsCommande;

        public DetailCommandeDAO()
        {
            marchesEntities = new MarchesEntities();
            detailsCommande = new DetailsCommande();
        }

        public DetailsCommande Save(DetailsCommande detailsCommande)
        {
            try
            {
                this.detailsCommande = detailsCommande;
                marchesEntities.DetailsCommandes.Add(this.detailsCommande);
                marchesEntities.SaveChanges();
                return this.detailsCommande;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible '!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<DetailsCommande> FindAll()
        {
            try
            {
                return marchesEntities.DetailsCommandes.ToList();
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
                detailsCommande = marchesEntities.DetailsCommandes.FirstOrDefault
                    (
                        detailsCommande => detailsCommande.DetailID == id
                    );
                marchesEntities.DetailsCommandes.Remove(detailsCommande);
                marchesEntities.SaveChanges();
                return detailsCommande.DetailID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible !\nErreur : {ex.Message}",
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
                return marchesEntities.DetailsCommandes.SingleOrDefault(medicament => medicament.DetailID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public DetailsCommande Update(DetailsCommande detailsCommande)
        {
            try
            {
                this.detailsCommande = detailsCommande;
                marchesEntities.DetailsCommandes.AddOrUpdate(this.detailsCommande);
                marchesEntities.SaveChanges();
                return this.detailsCommande;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible !\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
