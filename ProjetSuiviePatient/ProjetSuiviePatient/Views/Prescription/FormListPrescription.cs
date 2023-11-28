using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.AnalyseMedicale;
using ProjetSuiviePatient.Views.Medicament;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Prescription
{
    public partial class FormListPrescription : UserControl
    {
        private static FormListPrescription formList;

        PrescriptionControllers prescriptionControllers;

        string defaultInput = "Search...";

        public static FormListPrescription Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListPrescription();
                }
                return formList;
            }
        }
        public FormListPrescription()
        {
            InitializeComponent();
            prescriptionControllers = new PrescriptionControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(prescriptionControllers.FindAll());
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
                            id = prescriptionControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).ID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Prescription> prescriptions)
        {
            dataGridView1.Rows.Clear();

            prescriptions.ForEach
                (
                    delegate (Entities.Prescription prescription)
                    {
                        dataGridView1.Rows.Add(false, prescription.DatePrescription, prescription.PosologieGenerale, prescription.Instructions, prescription.Medecin.Nom,
                                                      prescription.Patient.Nom);
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
                    PopulateDataGridView(prescriptionControllers.FilterByName(input));
                    CountItems();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void FormListPrescription_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            FormPrescription formPatient = new FormPrescription();
            formPatient.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormPrescription formFonction = new FormPrescription
                        (prescriptionControllers.FindById(id));
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
                    int issue = prescriptionControllers.Delete(id);
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
    }
}
