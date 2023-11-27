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
                            $"Le patient '{patient.Nom} existe déjà !",
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

        public bool Exists(int id)
        {
            return patientDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<Patient> patients = FindAll();
                List<Patient> foundPatients = patients.FindAll
                    (
                        patient => patient.Nom == name
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

        public Patient FindByName(string name)
        {
            List<Patient> patients = FindAll();
            return patients.Find(patient => patient.Nom == name);
        }

        public Patient FindById(int id)
        {
            try
            {
                return FindAll().Find(patient => patient.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Patient> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    patient => patient.Nom.IndexOf
                    (
                        name,
                        StringComparison.CurrentCultureIgnoreCase
                    ) != -1
                ).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Patient Update(Patient patient)
        {
            try
            {
                bool hasThisIdHere = Exists(patient.ID);
                bool hasThisNameHere = Exists(patient.Nom);
                if (hasThisIdHere && !hasThisNameHere)
                    return patientDAO.Update(patient);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce patient n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                else if (hasThisNameHere)
                {
                    MessageBox.Show
                        (
                            $"Le patient '{patient.Nom}' existe déjà !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                if (Exists(id))
                    return patientDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce patient n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }
    }
}
