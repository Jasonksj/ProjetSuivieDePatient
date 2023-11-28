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

namespace ProjetSuiviePatient.Views.Medecin
{
    public partial class FormMedecin : Form
    {
        bool isUpdateForm;

        MedecinControllers medecinControllers;
        Entities.Medecin medecin;
        public FormMedecin()
        {
            InitializeComponent();
            isUpdateForm = false;
            medecinControllers = new MedecinControllers();
        }

        public FormMedecin(Entities.Medecin medecin)
        {
            InitializeComponent();
            this.medecin = medecin;
            isUpdateForm = true;
            medecinControllers = new MedecinControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN MEDECIN";
            else
            {
                titre.Text = "MODIFICATION D'UN MEDECIN";
                txt_nom.Text = medecin.Nom;
                txt_nom.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    medecin.Nom = txt_nom.Text;
                    Entities.Medecin medecinUpdated = medecinControllers.Update
                        (medecin);
                    if (medecinUpdated != null)
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
                    Entities.Medecin medecinCreated = medecinControllers.Save
                    (txt_nom.Text, txt_prenom.Text, txt_specialite.Text, txt_tel.Text, txt_email.Text, int.Parse(txt_anneeExp.Text), txt_certification.Text, txt_disponibilité.Text);
                    if (medecinCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du patient '{medecinCreated.Nom}' éffectuée avec succès !",
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

        private void FormMedecin_Load(object sender, EventArgs e)
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
