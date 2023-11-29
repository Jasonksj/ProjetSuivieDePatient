using Projet_Marche.Controllers;
using Projet_Marche.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.Views.Marche
{
    public partial class FormMarche : Form
    {
        bool isUpdateForm;

        MarchéControllers marchéControllers;
        Entities.March marche;
        public FormMarche()
        {
            InitializeComponent();
            isUpdateForm = false;
            marchéControllers = new MarchéControllers();
        }

        public FormMarche(Entities.March marche)
        {
            InitializeComponent();
            this.marche = marche;
            isUpdateForm = true;
            marchéControllers = new MarchéControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN MARCHE";
            else
            {
                titre.Text = "MODIFICATION D'UN MARCHE";
                btn_valider.Text = "Modifier";
                txt_nom.Text = marche.NomMarche;
                txt_adresse.Text = marche.AdresseMarche;
                txt_description.Text = marche.Description;
                txt_nom.Select();
            }
        }

        private void FormMarche_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    marche.NomMarche = txt_nom.Text;
                    marche.AdresseMarche = txt_adresse.Text;
                    marche.Description = txt_description.Text;
                    Entities.March marcheUpdated = marchéControllers.Update
                        (marche);
                    if (marcheUpdated != null)
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
                    Entities.March marcheCreated = marchéControllers.Save
                    (txt_nom.Text, txt_adresse.Text, txt_description.Text);
                    if (marcheCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du marché '{marcheCreated.NomMarche}' éffectuée avec succès !",
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
