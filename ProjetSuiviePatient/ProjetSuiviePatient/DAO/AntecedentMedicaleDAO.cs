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
    public class AntecedentMedicaleDAO
    {
        PatientEntities patientEntities;
        Antecedentmedical antecedentMedicale;

        public AntecedentMedicaleDAO()
        {
            patientEntities = new PatientEntities();
            antecedentMedicale = new Antecedentmedical();
        }

        public Antecedentmedical Save(Antecedentmedical antecedentMedicale)
        {
            try
            {
                this.antecedentMedicale = antecedentMedicale;
                patientEntities.Antecedentmedicals.Add(this.antecedentMedicale);
                patientEntities.SaveChanges();
                return this.antecedentMedicale;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible de l'antecedent medical du patient '{this.antecedentMedicale.Patient.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Antecedentmedical> FindAll()
        {
            try
            {
                return patientEntities.Antecedentmedicals.ToList();
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
                antecedentMedicale = patientEntities.Antecedentmedicals.FirstOrDefault
                    (
                        antecedentMedicale => antecedentMedicale.ID == id
                    );
                patientEntities.Antecedentmedicals.Remove(antecedentMedicale);
                patientEntities.SaveChanges();
                return antecedentMedicale.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible de l'antecedent medical du patient '{this.antecedentMedicale.Patient.Nom}'!\nErreur : {ex.Message}",
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
                return patientEntities.Antecedentmedicals.SingleOrDefault(antecedentMedicale => antecedentMedicale.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Antecedentmedical Update(Antecedentmedical antecedentMedicale)
        {
            try
            {
                this.antecedentMedicale = antecedentMedicale;
                patientEntities.Antecedentmedicals.AddOrUpdate(this.antecedentMedicale);
                patientEntities.SaveChanges();
                return this.antecedentMedicale;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible de l'antecedent medical du patient  '{this.antecedentMedicale.Patient.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
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
