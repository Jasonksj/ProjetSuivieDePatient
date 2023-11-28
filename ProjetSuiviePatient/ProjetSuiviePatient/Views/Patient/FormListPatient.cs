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

namespace ProjetSuiviePatient.Views.Patient
{
    public partial class FormListPatient : UserControl
    {
        private static FormListPatient formList;

        PatientControllers patientControllers;

        string defaultInput = "Search...";

        public static FormListPatient Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListPatient();
                }
                return formList;
            }
        }
        public FormListPatient()
        {
            InitializeComponent();
            patientControllers = new PatientControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(patientControllers.FindAll());
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
                            id = patientControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).ID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Patient> patients)
        {
            dataGridView1.Rows.Clear();

            patients.ForEach
                (
                    delegate (Entities.Patient patient)
                    {
                        dataGridView1.Rows.Add(false, patient.Nom, patient.Prenom, patient.DateNaissance, patient.Sexe,
                                                      patient.Adresse, patient.Telephone, patient.Email,  patient.DerniereVisite,
                                                      patient.GroupeSanguin, patient.NumeroAssuranceMaladie, patient.CommentairesMedicaux);
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
                    PopulateDataGridView(patientControllers.FilterByName(input));
                    CountItems();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void FormListPatient_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormPatient formFonction = new FormPatient
                        (patientControllers.FindById(id));
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
                    int issue = patientControllers.Delete(id);
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

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            FormPatient formPatient = new FormPatient();
            formPatient.ShowDialog();
        }
    }
}
