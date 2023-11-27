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
    public class AnalyseMedicaleDAO
    {
        PatientEntities patientEntities;
        Analysemedicale analyseMedicale;

        public AnalyseMedicaleDAO()
        {
            patientEntities = new PatientEntities();
            analyseMedicale = new Analysemedicale();
        }

        public Analysemedicale Save(Analysemedicale analyseMedicale)
        {
            try
            {
                this.analyseMedicale = analyseMedicale;
                patientEntities.Analysemedicales.Add(this.analyseMedicale);
                patientEntities.SaveChanges();
                return this.analyseMedicale;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible de l'analyse medicale du medecin '{this.analyseMedicale.Medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Analysemedicale> FindAll()
        {
            try
            {
                return patientEntities.Analysemedicales.ToList();
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
                analyseMedicale = patientEntities.Analysemedicales.FirstOrDefault
                    (
                        analyseMedicale => analyseMedicale.ID == id
                    );
                patientEntities.Analysemedicales.Remove(analyseMedicale);
                patientEntities.SaveChanges();
                return analyseMedicale.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible de l'analyse medicale du medecin '{this.analyseMedicale.Medecin.Nom}'!\nErreur : {ex.Message}",
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
                return patientEntities.Analysemedicales.SingleOrDefault(analyseMedicale => analyseMedicale.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
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

        public Analysemedicale Update(Analysemedicale analyseMedicale)
        {
            try
            {
                this.analyseMedicale = analyseMedicale;
                patientEntities.Analysemedicales.AddOrUpdate(this.analyseMedicale);
                patientEntities.SaveChanges();
                return this.analyseMedicale;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible de l'analyse medicale du medecin  '{this.analyseMedicale.Medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
