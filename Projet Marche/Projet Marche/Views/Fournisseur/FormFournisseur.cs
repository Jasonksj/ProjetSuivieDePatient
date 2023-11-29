using Projet_Marche.Controllers;
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

namespace Projet_Marche.Views.Fournisseur
{
    public partial class FormFournisseur : Form
    {
        bool isUpdateForm;

        FournisseurControllers fournisseurControllers;
        Entities.Fournisseur fournisseur;
        public FormFournisseur()
        {
            InitializeComponent();
            isUpdateForm = false;
            fournisseurControllers = new FournisseurControllers();
        }

        public FormFournisseur(Entities.Fournisseur fournisseur)
        {
            InitializeComponent();
            this.fournisseur = fournisseur;
            isUpdateForm = true;
            fournisseurControllers = new FournisseurControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                lblTitle.Text = "AJOUT D'UN FOURNISSEUR";
            else
            {
                lblTitle.Text = "MODIFICATION D'UN FOURNISSEUR";
                btn_valider.Text = "Modifier";
                txt_nom.Text = fournisseur.NomFournisseur;
                txt_adresse.Text = fournisseur.Adresse;
                txt_email.Text = fournisseur.Email;
                txt_nom.Select();
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

        private void FormFournisseur_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    fournisseur.NomFournisseur = txt_nom.Text;
                    fournisseur.Adresse = txt_adresse.Text;
                    fournisseur.Email = txt_email.Text;
                    Entities.Fournisseur fournisseurUpdated = fournisseurControllers.Update
                        (fournisseur);
                    if (fournisseurUpdated != null)
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
                    Entities.Fournisseur fournisseurCreated = fournisseurControllers.Save
                    (txt_nom.Text, txt_adresse.Text, txt_email.Text);
                    if (fournisseurCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du fournisseur '{fournisseurCreated.NomFournisseur}' éffectuée avec succès !",
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
    }
}
