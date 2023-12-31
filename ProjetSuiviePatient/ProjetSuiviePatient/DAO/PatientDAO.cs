﻿using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public int Delete(int id)
        {
            try
            {
                patient = patientEntities.Patients.FirstOrDefault
                    (
                        patient => patient.ID == id
                    );
                patientEntities.Patients.Remove(patient);
                patientEntities.SaveChanges();
                return patient.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du patient '{this.patient.Nom}'!\nErreur : {ex.Message}",
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
                return patientEntities.Patients.SingleOrDefault(patient => patient.ID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Patient Update(Patient patient)
        {
            try
            {
                this.patient = patient;
                patientEntities.Patients.AddOrUpdate(this.patient);
                patientEntities.SaveChanges();
                return this.patient;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du patient '{this.patient.Nom}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
