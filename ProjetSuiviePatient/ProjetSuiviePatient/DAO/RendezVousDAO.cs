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
    public class RendezVousDAO
    {
        PatientEntities patientEntities;
        Rendezvou rendezvous;

        public RendezVousDAO()
        {
            patientEntities = new PatientEntities();
            rendezvous = new Rendezvou();
        }

        public Rendezvou Save(Rendezvou rendezvous)
        {
            try
            {
                this.rendezvous = rendezvous;
                patientEntities.Rendezvous.Add(this.rendezvous);
                patientEntities.SaveChanges();
                return this.rendezvous;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du rendez vous du medecin '{this.rendezvous.Medecin.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Rendezvou> FindAll()
        {
            try
            {
                return patientEntities.Rendezvous.ToList();
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
                rendezvous = patientEntities.Rendezvous.FirstOrDefault
                    (
                        rendezvous => rendezvous.ID == id
                    );
                patientEntities.Rendezvous.Remove(rendezvous);
                patientEntities.SaveChanges();
                return rendezvous.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible de la prescription du medecin '{this.rendezvous.Medecin.Nom}'!\nErreur : {ex.Message}",
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
                return patientEntities.Rendezvous.SingleOrDefault(rendezvous => rendezvous.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Rendezvou Update(Rendezvou prescription)
        {
            try
            {
                this.rendezvous = prescription;
                patientEntities.Rendezvous.AddOrUpdate(this.rendezvous);
                patientEntities.SaveChanges();
                return this.rendezvous;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible de la prescription du medecin '{this.rendezvous.Medecin.Nom}'!\nErreur : {ex.Message}",
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
