using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.AntecedentMedical
{
    public partial class FormAntecedentMedicale : Form
    {
        bool isUpdateForm;

        AntecedentMedicaleControllers antecedentMedicaleControllers;
        Entities.Antecedentmedical antecedentmedical;
        PatientEntities entities;
        public FormAntecedentMedicale()
        {
            InitializeComponent();
            isUpdateForm = false;
            antecedentMedicaleControllers = new AntecedentMedicaleControllers();
            entities = new PatientEntities();
        }

        public FormAntecedentMedicale(Entities.Antecedentmedical antecedentmedical)
        {
            InitializeComponent();
            this.antecedentmedical = antecedentmedical;
            isUpdateForm = true;
            antecedentMedicaleControllers = new AntecedentMedicaleControllers();
            entities = new PatientEntities();
        }

        private void LoadForm()
        {
            patientID.DataSource = entities.Patients.Select( p => p.ID).ToList();
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN ANTECEDENT MEDICAL";
            else
            {
                titre.Text = "MODIFICATION D'UN ANTECEDENT MEDICAL";
                txt_type.Text = antecedentmedical.TypeAntecedent;
                txt_type.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    antecedentmedical.TypeAntecedent = txt_type.Text;
                    Entities.Antecedentmedical antecedentmedicaleUpdated = antecedentMedicaleControllers.Update
                        (antecedentmedical);
                    if (antecedentmedicaleUpdated != null)
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
                    Entities.Antecedentmedical antecedentMedicaleCreated = antecedentMedicaleControllers.Save
                    (txt_type.Text, txt_description.Text, datediagnostic.Value, txt_status.Text, selectedPatient);
                    if (antecedentMedicaleCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création de l'antecedent medical de type '{antecedentMedicaleCreated.TypeAntecedent}' éffectuée avec succès !",
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

        private void FormAntecedentMedicale_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void patientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupérez l'ID sélectionné.
            int selectedPatientId = (int)patientID.SelectedItem;

            // Récupérez le patient correspondant depuis la base de données.
            Entities.Patient selectedPatient = entities.Patients.FirstOrDefault(p => p.ID == selectedPatientId);

            // Affichez le nom du patient dans le TextBox.
            if (selectedPatient != null)
            {
                txt_nompatient.Text = selectedPatient.Nom;
            }
            else
            {
                txt_nompatient.Text = string.Empty;
            }
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
