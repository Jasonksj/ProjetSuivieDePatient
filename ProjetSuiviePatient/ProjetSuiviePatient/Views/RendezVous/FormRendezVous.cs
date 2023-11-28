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

namespace ProjetSuiviePatient.Views.RendezVous
{
    public partial class FormRendezVous : Form
    {
        bool isUpdateForm;

        RendezVousControllers rendezVousControllers;
        Entities.Rendezvou rendezvous;
        PatientEntities entities;
        public FormRendezVous()
        {
            InitializeComponent();
            isUpdateForm = false;
            rendezVousControllers = new RendezVousControllers();
            entities = new PatientEntities();
        }

        public FormRendezVous(Entities.Rendezvou rendezvous)
        {
            InitializeComponent();
            this.rendezvous = rendezvous;
            isUpdateForm = true;
            rendezVousControllers = new RendezVousControllers();
            entities = new PatientEntities();
        }

        private void LoadForm()
        {
            patientID.DataSource = entities.Patients.Select(p => p.ID).ToList();
            medecinID.DataSource = entities.Medecins.Select(p => p.ID).ToList();
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN RENDEZ VOUS";
            else
            {
                titre.Text = "MODIFICATION D'UN RENDEZ VOUS";
                btn_valider.Text = "Modifier";
                daterendezvous.Value = (DateTime)rendezvous.DateHeure;
                txt_motif.Select();
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

        private void FormRendezVous_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    rendezvous.DateHeure = daterendezvous.Value;
                    Entities.Rendezvou rendezvousUpdated = rendezVousControllers.Update
                        (rendezvous);
                    if (rendezvousUpdated != null)
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
                    Entities.Rendezvou rendezvousCreated = rendezVousControllers.Save
                    (daterendezvous.Value, selectedMedecin, selectedPatient, txt_motif.Text, txt_statut.Text, txt_remarque.Text, txt_urgence.Text);
                    if (rendezvousCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du rendez vous prevu pour le '{rendezvousCreated.DateHeure}' éffectuée avec succès !",
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
