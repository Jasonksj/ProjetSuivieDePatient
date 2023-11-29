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

namespace Projet_Marche.Views.Commande
{
    public partial class FormCommande : Form
    {
        bool isUpdateForm;

        CommandeControllers commandeControllers;
        Entities.Commande commande;
        MarchesEntities entities;
        public FormCommande()
        {
            InitializeComponent();
            isUpdateForm = false;
            commandeControllers = new CommandeControllers();
            entities = new MarchesEntities();
        }

        public FormCommande(Entities.Commande commande)
        {
            InitializeComponent();
            this.commande = commande;
            isUpdateForm = true;
            commandeControllers = new CommandeControllers();
            entities = new MarchesEntities();
        }

        private void LoadForm()
        {
            fournisseurID.DataSource = entities.Fournisseurs.Select(p => p.FournisseurID).ToList();
            clientID.DataSource = entities.Clients.Select(p => p.ClientID).ToList();
            marcheID.DataSource = entities.Marches.Select(p => p.MarcheID).ToList();
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UNE COMMANDE";
            else
            {
                titre.Text = "MODIFICATION D'UNE COMMANDE";
                btn_valider.Text = "Modifier";
                datecommande.Value = commande.DateCommande;
                txt_montant.Text = commande.MontantTotal.ToString();
                datecommande.Select();
            }
        }

        private void FormCommande_Load(object sender, EventArgs e)
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

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    commande.DateCommande = datecommande.Value;
                    commande.MontantTotal = Decimal.Parse(txt_montant.Text);
                    Entities.Commande commandeUpdated = commandeControllers.Update
                        (commande);
                    if (commandeUpdated != null)
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
                    int selectedFournisseurId = (int)fournisseurID.SelectedItem;
                    Entities.Fournisseur selectedFournisseur = entities.Fournisseurs.FirstOrDefault(p => p.FournisseurID == selectedFournisseurId);
                    int selectedClientId = (int)clientID.SelectedItem;
                    Entities.Client selectedClient = entities.Clients.FirstOrDefault(p => p.ClientID == selectedClientId);
                    int selectedMarcheId = (int)marcheID.SelectedItem;
                    Entities.March selectedMarche = entities.Marches.FirstOrDefault(p => p.MarcheID == selectedMarcheId);
                    Entities.Commande commandeCreated = commandeControllers.Save
                    (datecommande.Value, Decimal.Parse(txt_montant.Text), selectedFournisseur, selectedClient, selectedMarche);
                    if (commandeCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création de la commande '{commandeCreated.CommandeID}' éffectuée avec succès !",
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

        private void fournisseurID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFournisseurId = (int)fournisseurID.SelectedItem;
            Entities.Fournisseur selectedFournisseur = entities.Fournisseurs.FirstOrDefault(p => p.FournisseurID == selectedFournisseurId);
            if (selectedFournisseur != null)
            {
                txt_fournisseur.Text = selectedFournisseur.NomFournisseur;
            }
            else
            {
                txt_fournisseur.Text = string.Empty;
            }
        }

        private void clientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClientId = (int)clientID.SelectedItem;
            Entities.Client selectedClient = entities.Clients.FirstOrDefault(p => p.ClientID == selectedClientId);
            if (selectedClient != null)
            {
                txt_client.Text = selectedClient.NomClient;
            }
            else
            {
                txt_client.Text = string.Empty;
            }
        }

        private void marcheID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMarcheId = (int)marcheID.SelectedItem;
            Entities.March selectedMarche = entities.Marches.FirstOrDefault(p => p.MarcheID == selectedMarcheId);
            if (selectedMarche != null)
            {
                txt_marche.Text = selectedMarche.NomMarche;
            }
            else
            {
                txt_marche.Text = string.Empty;
            }
        }
    }
}
