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

namespace Projet_Marche.Views.DetailCommande
{
    public partial class FormDetailCommande : Form
    {
        bool isUpdateForm;

        DetailCommandeControllers detailCommandeControllers;
        Entities.DetailsCommande detailsCommande;
        MarchesEntities entities;
        public FormDetailCommande()
        {
            InitializeComponent();
            isUpdateForm = false;
            detailCommandeControllers = new DetailCommandeControllers();
            entities = new MarchesEntities();
        }

        public FormDetailCommande(Entities.DetailsCommande detailsCommande)
        {
            InitializeComponent();
            this.detailsCommande = detailsCommande;
            isUpdateForm = true;
            detailCommandeControllers = new DetailCommandeControllers();
            entities = new MarchesEntities();
        }

        private void LoadForm()
        {
            commandeID.DataSource = entities.Commandes.Select(p => p.CommandeID).ToList();
            produitID.DataSource = entities.Produits.Select(p => p.ProduitID).ToList();
            if (!isUpdateForm)
                titre.Text = "AJOUT DU DETAIL D'UNE COMMANDE";
            else
            {
                titre.Text = "MODIFICATION DU DETAIL D'UNE COMMANDE";
                btn_valider.Text = "Modifier";
                txt_quantite.Text = detailsCommande.Quantite.ToString();
                txt_prix.Text = detailsCommande.PrixUnitaire.ToString();
                txt_montant.Text = detailsCommande.MontantTotal.ToString();
                txt_quantite.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    detailsCommande.Quantite = int.Parse(txt_quantite.Text);
                    detailsCommande.PrixUnitaire = Decimal.Parse(txt_prix.Text);
                    detailsCommande.MontantTotal = Decimal.Parse(txt_montant.Text);
                    Entities.DetailsCommande detailsCommandeUpdated = detailCommandeControllers.Update
                        (detailsCommande);
                    if (detailsCommandeUpdated != null)
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
                    int selectedCommandeId = (int)commandeID.SelectedItem;
                    Entities.Commande selectedCommande = entities.Commandes.FirstOrDefault(p => p.CommandeID == selectedCommandeId);
                    int selectedProduitId = (int)produitID.SelectedItem;
                    Entities.Produit selectedProduit = entities.Produits.FirstOrDefault(p => p.ProduitID == selectedProduitId);
                    Entities.DetailsCommande detailsCommandeCreated = detailCommandeControllers.Save
                    (selectedCommande, selectedProduit, int.Parse(txt_quantite.Text), Decimal.Parse(txt_prix.Text), Decimal.Parse(txt_montant.Text));
                    if (detailsCommandeCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du detail de la commande '{detailsCommandeCreated.DetailID}' éffectuée avec succès !",
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

        private void FormDetailCommande_Load(object sender, EventArgs e)
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

        private void commandeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCommandeId = (int)commandeID.SelectedItem;
            Entities.Commande selectedCommande = entities.Commandes.FirstOrDefault(p => p.CommandeID == selectedCommandeId);
            if (selectedCommande != null)
            {
                txt_commande.Text = selectedCommande.MontantTotal.ToString() + " " + selectedCommande.DateCommande.ToString();
            }
            else
            {
                txt_commande.Text = string.Empty;
            }
        }

        private void produitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProduitId = (int)produitID.SelectedItem;
            Entities.Produit selectedProduit = entities.Produits.FirstOrDefault(p => p.ProduitID == selectedProduitId);
            if (selectedProduit != null)
            {
                txt_produit.Text = selectedProduit.NomProduit;
            }
            else
            {
                txt_produit.Text = string.Empty;
            }
        }
    }
}
