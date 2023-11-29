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
    public class MarcheDAO
    {
        MarchesEntities marchesEntities;
        March marche;

        public MarcheDAO()
        {
            marchesEntities = new MarchesEntities();
            marche = new March();
        }

        public March Save(March marche)
        {
            try
            {
                this.marche = marche;
                marchesEntities.Marches.Add(this.marche);
                marchesEntities.SaveChanges();
                return this.marche;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du marche '{this.marche.NomMarche}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<March> FindAll()
        {
            try
            {
                return marchesEntities.Marches.ToList();
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
                marche = marchesEntities.Marches.FirstOrDefault
                    (
                        marche => marche.MarcheID == id
                    );
                marchesEntities.Marches.Remove(marche);
                marchesEntities.SaveChanges();
                return marche.MarcheID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du marche '{this.marche.NomMarche}'!\nErreur : {ex.Message}",
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
                return marchesEntities.Marches.SingleOrDefault(marche => marche.MarcheID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public March Update(March prescription)
        {
            try
            {
                this.marche = prescription;
                marchesEntities.Marches.AddOrUpdate(this.marche);
                marchesEntities.SaveChanges();
                return this.marche;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du marche'{this.marche.NomMarche}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
