using ProjetSuiviePatient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjetSuiviePatient.Views.Patient
{
    public partial class FormPatient : Form
    {
        bool isUpdateForm;

        PatientControllers patientControllers;
        Entities.Patient patient;
        public FormPatient()
        {
            InitializeComponent();
            isUpdateForm = false;
            patientControllers = new PatientControllers();
        }

        public FormPatient(Entities.Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            isUpdateForm = true;
            patientControllers = new PatientControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                lblTitle.Text = "AJOUT D'UN PATIENT";
            else
            {
                lblTitle.Text = "MODIFICATION D'UN PATIENT";
                btn_valider.Text = "Modifier";
                txt_nom.Text = patient.Nom;
                txt_prenom.Text = patient.Prenom;
                dateNaiss.Value = (DateTime)patient.DateNaissance;
                txt_sexe.Text = patient.Sexe;
                txt_adresse.Text = patient.Adresse;
                txt_tel.Text = patient.Telephone;
                txt_email.Text = patient.Email;
                dervisite.Value = (DateTime)patient.DerniereVisite;
                groupsanguin.SelectedText = patient.GroupeSanguin;
                txt_assurance.Text = patient.NumeroAssuranceMaladie;
                txt_commentaire.Text = patient.CommentairesMedicaux;
                txt_nom.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    patient.Nom = txt_nom.Text;
                    Entities.Patient patientUpdated = patientControllers.Update
                        (patient);
                    if (patientUpdated != null)
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
                    Entities.Patient patientCreated = patientControllers.Save
                    (txt_nom.Text, txt_prenom.Text, dateNaiss.Value, txt_sexe.SelectedText, txt_adresse.Text, txt_tel.Text,
                    txt_email.Text, dervisite.Value, groupsanguin.SelectedText, txt_assurance.Text, txt_commentaire.Text);
                    if (patientCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du patient '{patientCreated.Nom}' éffectuée avec succès !",
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

        private void FormPatient_Load(object sender, EventArgs e)
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
