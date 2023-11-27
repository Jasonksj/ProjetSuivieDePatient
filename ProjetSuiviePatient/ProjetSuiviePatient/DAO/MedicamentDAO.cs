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
    public class MedicamentDAO
    {
        PatientEntities patientEntities;
        Medicament medicament;

        public MedicamentDAO()
        {
            patientEntities = new PatientEntities();
            medicament = new Medicament();
        }

        public Medicament Save(Medicament medicament)
        {
            try
            {
                this.medicament = medicament;
                patientEntities.Medicaments.Add(this.medicament);
                patientEntities.SaveChanges();
                return this.medicament;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du medicament '{this.medicament.NomMedicament}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Medicament> FindAll()
        {
            try
            {
                return patientEntities.Medicaments.ToList();
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
                medicament = patientEntities.Medicaments.FirstOrDefault
                    (
                        medicament => medicament.ID == id
                    );
                patientEntities.Medicaments.Remove(medicament);
                patientEntities.SaveChanges();
                return medicament.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du medicament '{this.medicament.NomMedicament}'!\nErreur : {ex.Message}",
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
                return patientEntities.Medicaments.SingleOrDefault(medicament => medicament.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Medicament Update(Medicament medicament)
        {
            try
            {
                this.medicament = medicament;
                patientEntities.Medicaments.AddOrUpdate(this.medicament);
                patientEntities.SaveChanges();
                return this.medicament;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du medicament '{this.medicament.NomMedicament}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
