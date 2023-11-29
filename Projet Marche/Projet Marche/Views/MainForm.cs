using Projet_Marche.Views.Client;
using Projet_Marche.Views.Commande;
using Projet_Marche.Views.DetailCommande;
using Projet_Marche.Views.Fournisseur;
using Projet_Marche.Views.Marche;
using Projet_Marche.Views.Produit;
using Projet_Marche.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Souhaitez-vous vraiment quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_medicaent_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_client.Top;
            if (!main.Controls.Contains(FormListClient.Instance))
            {
                main.Controls.Add(FormListClient.Instance);
                FormListClient.Instance.Dock = DockStyle.Fill;
                FormListClient.Instance.BringToFront();
            }
            else
            {
                FormListClient.Instance.BringToFront();
            }
        }

        private void btn_commande_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_commande.Top;
            if (!main.Controls.Contains(FormListCommande.Instance))
            {
                main.Controls.Add(FormListCommande.Instance);
                FormListCommande.Instance.Dock = DockStyle.Fill;
                FormListCommande.Instance.BringToFront();
            }
            else
            {
                FormListCommande.Instance.BringToFront();
            }
        }

        private void btn_detailcommande_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_detailcommande.Top;
            if (!main.Controls.Contains(FormListDetailCommande.Instance))
            {
                main.Controls.Add(FormListDetailCommande.Instance);
                FormListDetailCommande.Instance.Dock = DockStyle.Fill;
                FormListDetailCommande.Instance.BringToFront();
            }
            else
            {
                FormListDetailCommande.Instance.BringToFront();
            }
        }

        private void btn_fournisseur_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_fournisseur.Top;
            if (!main.Controls.Contains(FormListFournisseur.Instance))
            {
                main.Controls.Add(FormListFournisseur.Instance);
                FormListFournisseur.Instance.Dock = DockStyle.Fill;
                FormListFournisseur.Instance.BringToFront();
            }
            else
            {
                FormListFournisseur.Instance.BringToFront();
            }
        }

        private void btn_marche_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_marche.Top;
            if (!main.Controls.Contains(FormListMarche.Instance))
            {
                main.Controls.Add(FormListMarche.Instance);
                FormListMarche.Instance.Dock = DockStyle.Fill;
                FormListMarche.Instance.BringToFront();
            }
            else
            {
                FormListMarche.Instance.BringToFront();
            }
        }

        private void btn_produit_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_produit.Top;
            if (!main.Controls.Contains(FormListProduit.Instance))
            {
                main.Controls.Add(FormListProduit.Instance);
                FormListProduit.Instance.Dock = DockStyle.Fill;
                FormListProduit.Instance.BringToFront();
            }
            else
            {
                FormListProduit.Instance.BringToFront();
            }
        }

        private void btn_deconnec_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Souhaitez-vous vraiment vous deconnecter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                FormLogin frmlogin = new FormLogin();
                frmlogin.Show();
                this.Hide();
            }
        }
    }
}
