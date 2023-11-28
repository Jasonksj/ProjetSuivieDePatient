using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Prescription
{
    public partial class FormPrescription : Form
    {
        bool isUpdateForm;

        PrescriptionControllers prescriptionControllers;
        Entities.Prescription prescription;
        PatientEntities entities;
        public FormPrescription()
        {
            InitializeComponent();
            isUpdateForm = false;
            prescriptionControllers = new PrescriptionControllers();
            entities = new PatientEntities();
        }

        public FormPrescription(Entities.Prescription prescription)
        {
            InitializeComponent();
            this.prescription = prescription;
            isUpdateForm = true;
            prescriptionControllers = new PrescriptionControllers();
            entities = new PatientEntities();
        }

        private void LoadForm()
        {
            patientID.DataSource = entities.Patients.Select(p => p.ID).ToList();
            medecinID.DataSource = entities.Medecins.Select(p => p.ID).ToList();
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UNE PRESCRIPTION";
            else
            {
                titre.Text = "MODIFICATION D'UNE PRESCRIPTION";
                btn_valider.Text = "Modifier";
                datePrescription.Value = (DateTime)prescription.DatePrescription;
                txt_posologie.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    prescription.DatePrescription = datePrescription.Value;
                    Entities.Prescription prescriptionUpdated = prescriptionControllers.Update
                        (prescription);
                    if (prescriptionUpdated != null)
                    {
                        MessageBox.Show
                            (
                                "Modification éffectuée avec succès !",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        Close();
                    }
                }
                else
                {
                    int selectedPatientId = (int)patientID.SelectedItem;
                    Entities.Patient selectedPatient = entities.Patients.FirstOrDefault(p => p.ID == selectedPatientId);
                    int selectedMedecinId = (int)medecinID.SelectedItem;
                    Entities.Medecin selectedMedecin = entities.Medecins.FirstOrDefault(p => p.ID == selectedMedecinId);
                    Entities.Prescription prescriptionCreated = prescriptionControllers.Save
                    (datePrescription.Value, txt_posologie.Text, txt_instruction.Text, selectedMedecin, selectedPatient);
                    if (prescriptionCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création de la prescription le '{prescriptionCreated.DatePrescription}' éffectuée avec succès !",
                               "Succès",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
                           );
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void medecinID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMedecintId = (int)medecinID.SelectedItem;
            Entities.Medecin selectedMedecin = entities.Medecins.FirstOrDefault(p => p.ID == selectedMedecintId);
            if (selectedMedecin != null)
            {
                txt_medecin.Text = selectedMedecin.Nom;
            }
            else
            {
                txt_medecin.Text = string.Empty;
            }
        }

        private void patientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPatientId = (int)patientID.SelectedItem;
            Entities.Patient selectedPatient = entities.Patients.FirstOrDefault(p => p.ID == selectedPatientId);
            if (selectedPatient != null)
            {
                txt_patient.Text = selectedPatient.Nom;
            }
            else
            {
                txt_patient.Text = string.Empty;
            }
        }

        private void FormPrescription_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
