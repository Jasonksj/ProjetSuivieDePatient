using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.Medicament;
using ProjetSuiviePatient.Views.Prescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.RendezVous
{
    public partial class FormListRendezVous : UserControl
    {
        private static FormListRendezVous formList;

        RendezVousControllers rendezVousControllers;

        string defaultInput = "Search...";

        public static FormListRendezVous Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListRendezVous();
                }
                return formList;
            }
        }
        public FormListRendezVous()
        {
            InitializeComponent();
            rendezVousControllers = new RendezVousControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(rendezVousControllers.FindAll());
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
                            id = rendezVousControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).ID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Rendezvou> rendezvous)
        {
            dataGridView1.Rows.Clear();

            rendezvous.ForEach
                (
                    delegate (Entities.Rendezvou rendezvou)
                    {
                        dataGridView1.Rows.Add(false, rendezvou.DateHeure, rendezvou.Medecin.Nom,rendezvou.Patient.Nom, 
                            rendezvou.Motif, rendezvou.Statut, rendezvou.Remarques, rendezvou.Urgence );
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
                    PopulateDataGridView(rendezVousControllers.FilterByName(input));
                    CountItems();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void FormListPresription_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            FormRendezVous formPatient = new FormRendezVous();
            formPatient.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormRendezVous formFonction = new FormRendezVous
                        (rendezVousControllers.FindById(id));
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
                    int issue = rendezVousControllers.Delete(id);
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

        private void FormListRendezVous_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
