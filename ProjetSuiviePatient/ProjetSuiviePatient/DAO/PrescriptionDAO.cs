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
    public class PrescriptionDAO
    {
        PatientEntities patientEntities;
        Prescription prescription;

        public PrescriptionDAO()
        {
            patientEntities = new PatientEntities();
            prescription = new Prescription();
        }

        public Prescription Save(Prescription prescription)
        {
            try
            {
                this.prescription = prescription;
                patientEntities.Prescriptions.Add(this.prescription);
                patientEntities.SaveChanges();
                return this.prescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible de la prescription du medecin '{this.prescription.Medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Prescription> FindAll()
        {
            try
            {
                return patientEntities.Prescriptions.ToList();
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
                prescription = patientEntities.Prescriptions.FirstOrDefault
                    (
                        prescription => prescription.ID == id
                    );
                patientEntities.Prescriptions.Remove(prescription);
                patientEntities.SaveChanges();
                return prescription.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible de la prescription du medecin '{this.prescription.Medecin.Nom}'!\nErreur : {ex.Message}",
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
                return patientEntities.Prescriptions.SingleOrDefault(prescription => prescription.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Prescription Update(Prescription prescription)
        {
            try
            {
                this.prescription = prescription;
                patientEntities.Prescriptions.AddOrUpdate(this.prescription);
                patientEntities.SaveChanges();
                return this.prescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible de la prescription du medecin '{this.prescription.Medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public int MedecinID()
        {
            try
            {
                return patientEntities.Medecins.SingleOrDefault().ID;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public int PatientID()
        {
            try
            {
                return patientEntities.Patients.SingleOrDefault().ID;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }
    }
}
