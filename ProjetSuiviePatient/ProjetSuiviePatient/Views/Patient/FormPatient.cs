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

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Patient patientCreated = patientControllers.Save
                    (txt_nom.Text, txt_prenom.Text, dateNaiss.Value, "", txt_adresse.Text, txt_tel.Text, 
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
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }
    }
}
