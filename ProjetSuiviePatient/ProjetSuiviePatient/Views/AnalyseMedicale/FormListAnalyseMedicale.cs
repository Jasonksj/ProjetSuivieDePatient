using ProjetSuiviePatient.Controllers;
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

namespace ProjetSuiviePatient.Views.AnalyseMedicale
{
    public partial class FormListAnalyseMedicale : UserControl
    {
        private static FormListAnalyseMedicale formList;

        AnalyseMedicaleControllers analyseMedicaleControllers;

        string defaultInput = "Search...";

        public static FormListAnalyseMedicale Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListAnalyseMedicale();
                }
                return formList;
            }
        }
        public FormListAnalyseMedicale()
        {
            InitializeComponent();
            analyseMedicaleControllers = new AnalyseMedicaleControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(analyseMedicaleControllers.FindAll());
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
                            id = analyseMedicaleControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).ID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Analysemedicale> analysemedicales)
        {
            dataGridView1.Rows.Clear();

            analysemedicales.ForEach
                (
                    delegate (Entities.Analysemedicale analysemedicale)
                    {
                        dataGridView1.Rows.Add(false, analysemedicale.DateAnalyse, analysemedicale.TypeAnalyse, analysemedicale.Resultats, analysemedicale.Laboratoire,
                                                      analysemedicale.CommentairesResultats, analysemedicale.Medecin.Nom, analysemedicale.Patient.Nom);
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
                    PopulateDataGridView(analyseMedicaleControllers.FilterByName(input));
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
            FormAnalyseMedicale formPatient = new FormAnalyseMedicale();
            formPatient.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormAnalyseMedicale formFonction = new FormAnalyseMedicale
                        (analyseMedicaleControllers.FindById(id));
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
                    int issue = analyseMedicaleControllers.Delete(id);
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

        private void FormListAnalyseMedicale_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
