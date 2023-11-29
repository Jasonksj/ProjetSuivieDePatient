using Projet_Marche.Controllers;
using Projet_Marche.Views.Commande;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.Views.Commande
{
    public partial class FormListCommande : UserControl
    {
        private static FormListCommande formList;

        CommandeControllers commandeControllers;

        string defaultInput = "Search...";

        public static FormListCommande Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListCommande();
                }
                return formList;
            }
        }
        public FormListCommande()
        {
            InitializeComponent();
            commandeControllers = new CommandeControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(commandeControllers.FindAll());
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
                            id = commandeControllers.FindByName(dataGridView1.SelectedRows[i].Cells[1].Value.ToString()).CommandeID;
                    }
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void PopulateDataGridView(List<Entities.Commande> commandes)
        {
            dataGridView1.Rows.Clear();

            commandes.ForEach
                (
                    delegate (Entities.Commande commande)
                    {
                        dataGridView1.Rows.Add(false, commande.DateCommande, commande.MontantTotal, commande.Fournisseur, commande.Client,
                                                      commande.March);
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
                    PopulateDataGridView(commandeControllers.FilterByName(input));
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
            FormCommande formPatient = new FormCommande();
            formPatient.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetIdOfSelectedFonction();
                if (id != -1)
                {
                    FormCommande formFonction = new FormCommande
                        (commandeControllers.FindById(id));
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
                    int issue = commandeControllers.Delete(id);
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

        private void FormListCommande_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
