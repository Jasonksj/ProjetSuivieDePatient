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

namespace ProjetSuiviePatient.Views.Medicament
{
    public partial class FormMedicament : Form
    {
        bool isUpdateForm;

        MedicamentControllers medicamentControllers;
        Entities.Medicament medicament;
        public FormMedicament()
        {
            InitializeComponent();
            isUpdateForm = false;
            medicamentControllers = new MedicamentControllers();
        }

        public FormMedicament(Entities.Medicament medicament)
        {
            InitializeComponent();
            this.medicament = medicament;
            isUpdateForm = true;
            medicamentControllers = new MedicamentControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN PATIENT";
            else
            {
                titre.Text = "MODIFICATION D'UN PATIENT";
                btn_valider.Text = "Modifier";
                txt_nom.Text = medicament.NomMedicament;
                txt_description.Text = medicament.Description;
                txt_posologie.Text = medicament.Posologie;
                txt_forme.Text = medicament.FormeMedicament;
                txt_fabricant.Text = medicament.Fabricant;
                txt_nom.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    medicament.NomMedicament = txt_nom.Text;
                    Entities.Medicament medicamentUpdated = medicamentControllers.Update
                        (medicament);
                    if (medicamentUpdated != null)
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
                    Entities.Medicament medicamentCreated = medicamentControllers.Save
                    (txt_nom.Text, txt_description.Text, txt_posologie.Text, txt_forme.Text, txt_fabricant.Text);
                    if (medicamentCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du medicament '{medicamentCreated.NomMedicament}' éffectuée avec succès !",
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

        private void FormMedicament_Load(object sender, EventArgs e)
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
