using ProjetSuiviePatient.DAO;
using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Services
{
    public class PatientService
    {
        PatientDAO patientDAO;

        public PatientService()
        {
            patientDAO = new PatientDAO();
        }

        // CREATE
        public Patient Save(Patient patient)
        {
            try
            {
                if (!Exists(patient.Nom))
                    return patientDAO.Save(patient);
                else
                {
                    MessageBox.Show
                        (
                            $"La fonction '{patient.Nom} existe déjà !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(string name)
        {
            try
            {
                List<Patient> patients = FindAll();
                List<Patient> foundPatients = patients.FindAll
                    (
                        fonction => fonction.Nom == name
                    );

                return foundPatients.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Patient> FindAll()
        {
            return patientDAO.FindAll();
        }

        //// READ
        //public List<Patient> FindAllPatients()
        //{
        //    try
        //    {
        //        return _context.Patients.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Erreur {ex.Message}");
        //    }
        //}

        //public Patient GetPatientById(int patientId)
        //{
        //    try
        //    {
        //        return _context.Patients.Find(patientId);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Erreur {ex.Message}");
        //    }
        //}

        //// UPDATE
        //public void UpdatePatient(Patient updatedPatient)
        //{
        //    try
        //    {
        //        var existingPatient = _context.Patients.Find(updatedPatient.ID);

        //        if (existingPatient != null)
        //        {
        //            existingPatient.Nom = updatedPatient.Nom;
        //            existingPatient.Prenom = updatedPatient.Prenom;
        //            existingPatient.DateNaissance = updatedPatient.DateNaissance;
        //            existingPatient.Sexe = updatedPatient.Sexe;
        //            existingPatient.Adresse = updatedPatient.Adresse;
        //            existingPatient.Telephone = updatedPatient.Telephone;
        //            existingPatient.Email = updatedPatient.Email;
        //            existingPatient.DerniereVisite = updatedPatient.DerniereVisite;
        //            existingPatient.GroupeSanguin = updatedPatient.GroupeSanguin;
        //            existingPatient.NumeroAssuranceMaladie = updatedPatient.NumeroAssuranceMaladie;
        //            existingPatient.CommentairesMedicaux = updatedPatient.CommentairesMedicaux;
        //            _context.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Erreur {ex.Message}");
        //    }
        //}

        //// DELETE
        //public int DeletePatient(int patienttId)
        //{
        //    try
        //    {
        //        patient = _context.Patients.FirstOrDefault
        //        (
        //            patient => patient.ID == patienttId
        //        );
        //        _context.Patients.Remove(patient);
        //        _context.SaveChanges();
        //        return patient.ID;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show
        //        (
        //                $"Suppression du paiement de l'employé impossible !\nErreur : {ex.Message}",
        //                "Echec",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error
        //            );
        //        return -1;
        //    }
        //}
    }
}
