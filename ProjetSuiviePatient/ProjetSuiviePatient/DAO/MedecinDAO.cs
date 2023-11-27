using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.DAO
{
    public class MedecinDAO
    {
        PatientEntities patientEntities;
        Medecin medecin;

        public MedecinDAO()
        {
            patientEntities = new PatientEntities();
            medecin = new Medecin();
        }

        public Medecin Save(Medecin medecin)
        {
            try
            {
                this.medecin = medecin;
                patientEntities.Medecins.Add(this.medecin);
                patientEntities.SaveChanges();
                return this.medecin;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du medecin '{this.medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Medecin> FindAll()
        {
            try
            {
                return patientEntities.Medecins.ToList();
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
                medecin = patientEntities.Medecins.FirstOrDefault
                    (
                        medecin => medecin.ID == id
                    );
                patientEntities.Medecins.Remove(medecin);
                patientEntities.SaveChanges();
                return medecin.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du Medecin '{this.medecin.Nom}'!\nErreur : {ex.Message}",
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
                return patientEntities.Medecins.SingleOrDefault(medecin => medecin.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Medecin Update(Medecin medecin)
        {
            try
            {
                this.medecin = medecin;
                patientEntities.Medecins.AddOrUpdate(this.medecin);
                patientEntities.SaveChanges();
                return this.medecin;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du Medecin '{this.medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null; 
            }
        }
    }
}
