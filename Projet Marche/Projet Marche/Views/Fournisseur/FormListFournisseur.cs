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

namespace Projet_Marche.Views.Fournisseur
{
    public partial class FormListFournisseur : UserControl
    {
        private static FormListFournisseur formList;

        FournisseurControllers fournisseurControllers;

        string defaultInput = "Search...";

        public static FormListFournisseur Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListFournisseur();
                }
                return formList;
            }
        }
        public FormListFournisseur()
        {
            InitializeComponent();
            fournisseurControllers = new FournisseurControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(fournisseurControllers.FindAll());
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
                            id = fournisseurControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).FournisseurID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Fournisseur> fournisseurs)
        {
            dataGridView1.Rows.Clear();

            fournisseurs.ForEach
                (
                    delegate (Entities.Fournisseur fournisseur)
                    {
                        dataGridView1.Rows.Add(false, fournisseur.NomFournisseur, fournisseur.Adresse, fournisseur.Email);
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
                    PopulateDataGridView(fournisseurControllers.FilterByName(input));
                    CountItems();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            FormFournisseur formPatient = new FormFournisseur();
            formPatient.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormFournisseur formFonction = new FormFournisseur
                        (fournisseurControllers.FindById(id));
                    formFonction.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();

                if (id != -1)
                {
                    int issue = fournisseurControllers.Delete(id);
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

        private void FormListFournisseur_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
