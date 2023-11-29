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

namespace Projet_Marche.Views.Produit
{
    public partial class FormProduit : Form
    {
        bool isUpdateForm;

        ProduitControllers produitControllers;
        Entities.Produit produit;
        public FormProduit()
        {
            InitializeComponent();
            isUpdateForm = false;
            produitControllers = new ProduitControllers();
        }

        public FormProduit(Entities.Produit produit)
        {
            InitializeComponent();
            this.produit = produit;
            isUpdateForm = true;
            produitControllers = new ProduitControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN PRODUIT";
            else
            {
                titre.Text = "MODIFICATION D'UN PRODUIT";
                btn_valider.Text = "Modifier";
                txt_nom.Text = produit.NomProduit;
                txt_prix.Text = produit.Prix.ToString();
                txt_stock.Text = produit.Stock.ToString();
                txt_nom.Select();
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    produit.NomProduit = txt_nom.Text;
                    produit.Prix = Decimal.Parse(txt_prix.Text);
                    produit.Stock = int.Parse(txt_stock.Text);
                    Entities.Produit produitUpdated = produitControllers.Update
                        (produit);
                    if (produitUpdated != null)
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
                    Entities.Produit produitCreated = produitControllers.Save(txt_nom.Text, Decimal.Parse(txt_prix.Text), int.Parse(txt_stock.Text));
                    if (produitCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du produit '{produitCreated.NomProduit}' éffectuée avec succès !",
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

        private void FormProduit_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
