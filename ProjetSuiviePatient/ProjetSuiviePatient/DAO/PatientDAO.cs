using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.DAO
{
    public class PatientDAO
    {
        PatientEntities patientEntities;
        Patient patient;

        public PatientDAO()
        {
            patientEntities = new PatientEntities();
            patient = new Patient();
        }

        public Patient Save(Patient patient)
        {
            try
            {
                this.patient = patient;
                patientEntities.Patients.Add(this.patient);
                patientEntities.SaveChanges();
                return this.patient;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du patient '{this.patient.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Patient> FindAll()
        {
            try
            {
                return patientEntities.Patients.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }
    }
}
