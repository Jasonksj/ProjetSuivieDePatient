using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.AnalyseMedicale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.AntecedentMedical
{
    public partial class FormListAntecedentMedicale : UserControl
    {
        private static FormListAntecedentMedicale formList;

        AntecedentMedicaleControllers antecedentMedicaleControllers;

        string defaultInput = "Search...";

        public static FormListAntecedentMedicale Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListAntecedentMedicale();
                }
                return formList;
            }
        }
        public FormListAntecedentMedicale()
        {
            InitializeComponent();
            antecedentMedicaleControllers = new AntecedentMedicaleControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(antecedentMedicaleControllers.FindAll());
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
                            id = antecedentMedicaleControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).ID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Antecedentmedical> antecedentmedicals)
        {
            dataGridView1.Rows.Clear();

            antecedentmedicals.ForEach
                (
                    delegate (Entities.Antecedentmedical antecedentmedical)
                    {
                        dataGridView1.Rows.Add(false, antecedentmedical.TypeAntecedent, antecedentmedical.Description, antecedentmedical.DateDiagnostic, antecedentmedical.Statut,
                                                      antecedentmedical.Patient.Nom);
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
                    PopulateDataGridView(antecedentMedicaleControllers.FilterByName(input));
                    CountItems();
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
                    int issue = antecedentMedicaleControllers.Delete(id);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormAntecedentMedicale formFonction = new FormAntecedentMedicale
                        (antecedentMedicaleControllers.FindById(id));
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
            FormAntecedentMedicale formPatient = new FormAntecedentMedicale();
            formPatient.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void FormListAntecedentMedicale_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
