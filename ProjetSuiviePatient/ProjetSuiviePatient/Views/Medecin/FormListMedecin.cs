using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.AntecedentMedical;
using ProjetSuiviePatient.Views.Patient;
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
    public partial class FormListMedecin : UserControl
    {
        private static FormListMedecin formList;

        MedecinControllers medecinControllers;

        string defaultInput = "Search...";

        public static FormListMedecin Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListMedecin();
                }
                return formList;
            }
        }
        public FormListMedecin()
        {
            InitializeComponent();
            medecinControllers = new MedecinControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(medecinControllers.FindAll());
            CountItems();
            txtSearch.SelectAll();
        }

        private int GetIdOfSelectedFonction()
        {
            try
            {
                int id = -1;
                int selectedRows = dataGridView1.SelectedRows.Count;

                if (selectedRows < 1)
                    MessageBox.Show
                        (
                            "Vous n'avez sélectionné aucune ligne !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                else if (selectedRows > 1)
                    MessageBox.Show
                        (
                            "Vous avez sélectionné beaucoup trop de lignes !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                else
                {
                    for (int i = 0; i < selectedRows; i++)
                    {
                        if ((bool)dataGridView1.SelectedRows[i].Cells[0].Value == true)
                            id = medecinControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).ID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Medecin> medecins)
        {
            dataGridView1.Rows.Clear();

            medecins.ForEach
                (
                    delegate (Entities.Medecin medecin)
                    {
                        dataGridView1.Rows.Add(false, medecin.Nom, medecin.Prenom, medecin.Specialite, medecin.Telephone,
                                                      medecin.Email, medecin.AnneesExperience, medecin.Certifications, medecin.Disponibilite);
                    }
                );
        }

        private void CountItems()
        {
            lblCount.Text = (dataGridView1.Rows.Count - 1).ToString();
        }

        private void FilterByInput(object sender, EventArgs e)
        {
            try
            {
                string input = txtSearch.Text;
                if (input.Length == 0)
                {
                    txtSearch.Text = defaultInput;
                    txtSearch.SelectAll();
                }
                else
                {
                    PopulateDataGridView(medecinControllers.FilterByName(input));
                    CountItems();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormMedecin formFonction = new FormMedecin
                        (medecinControllers.FindById(id));
                    formFonction.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            FormMedecin formPatient = new FormMedecin();
            formPatient.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();

                if (id != -1)
                {
                    int issue = medecinControllers.Delete(id);
                    if (issue != -1)
                        MessageBox.Show
                            (
                                "Suppression éffectuée avec succès !",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void FormListMedecin_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
