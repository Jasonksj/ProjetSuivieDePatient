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

namespace ProjetSuiviePatient.Views.AnalyseMedicale
{
    public partial class FormAnalyseMedicale : Form
    {
        bool isUpdateForm;

        AnalyseMedicaleControllers analyseMedicaleControllers;
        Entities.Analysemedicale analysemedicale;
        PatientEntities entities;
        public FormAnalyseMedicale()
        {
            InitializeComponent();
            isUpdateForm = false;
            analyseMedicaleControllers = new AnalyseMedicaleControllers();
            entities = new PatientEntities();
        }

        public FormAnalyseMedicale(Entities.Analysemedicale analysemedicale)
        {
            InitializeComponent();
            this.analysemedicale = analysemedicale;
            isUpdateForm = true;
            analyseMedicaleControllers = new AnalyseMedicaleControllers();
            entities = new PatientEntities();
        }

        private void LoadForm()
        {
            patientID.DataSource = entities.Patients.Select(p => p.ID).ToList();
            medecinID.DataSource = entities.Medecins.Select(p => p.ID).ToList();
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UNE ANALYSE MEDICALE";
            else
            {
                titre.Text = "MODIFICATION D'UNE ANALYSE MEDICALE";
                txt_type.Text = analysemedicale.TypeAnalyse;
                txt_type.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    analysemedicale.TypeAnalyse = txt_type.Text;
                    Entities.Analysemedicale analysemedicaleUpdated = analyseMedicaleControllers.Update
                        (analysemedicale);
                    if (analysemedicaleUpdated != null)
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
                    Entities.Analysemedicale analyseMedicaleCreated = analyseMedicaleControllers.Save
                    (dateAnalyse.Value, txt_type.Text, txt_resultat.Text, txt_labo.Text, txt_commentaire.Text, selectedMedecin, selectedPatient);
                    if (analyseMedicaleCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création de l'analyse medicale de type '{analyseMedicaleCreated.TypeAnalyse}' éffectuée avec succès !",
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

        private void FormAnalyseMedicale_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void medecinID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupérez l'ID sélectionné.
            int selectedMedecintId = (int)medecinID.SelectedItem;

            // Récupérez le patient correspondant depuis la base de données.
            Entities.Medecin selectedMedecin = entities.Medecins.FirstOrDefault(p => p.ID == selectedMedecintId);

            // Affichez le nom du patient dans le TextBox.
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
            // Récupérez l'ID sélectionné.
            int selectedPatientId = (int)patientID.SelectedItem;

            // Récupérez le patient correspondant depuis la base de données.
            Entities.Patient selectedPatient = entities.Patients.FirstOrDefault(p => p.ID == selectedPatientId);

            // Affichez le nom du patient dans le TextBox.
            if (selectedPatient != null)
            {
                txt_patient.Text = selectedPatient.Nom;
            }
            else
            {
                txt_patient.Text = string.Empty;
            }
        }
    }
}
