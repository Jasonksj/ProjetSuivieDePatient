using System.Drawing;
using System.Windows.Forms;

namespace Projet_Marche.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deconnec = new System.Windows.Forms.Button();
            this.btn_produit = new System.Windows.Forms.Button();
            this.btn_fournisseur = new System.Windows.Forms.Button();
            this.btn_marche = new System.Windows.Forms.Button();
            this.btn_detailcommande = new System.Windows.Forms.Button();
            this.btn_commande = new System.Windows.Forms.Button();
            this.pnlbat = new System.Windows.Forms.Panel();
            this.btn_client = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_deconnec);
            this.panel1.Controls.Add(this.btn_produit);
            this.panel1.Controls.Add(this.btn_fournisseur);
            this.panel1.Controls.Add(this.btn_marche);
            this.panel1.Controls.Add(this.btn_detailcommande);
            this.panel1.Controls.Add(this.btn_commande);
            this.panel1.Controls.Add(this.pnlbat);
            this.panel1.Controls.Add(this.btn_client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 894);
            this.panel1.TabIndex = 0;
            // 
            // btn_deconnec
            // 
            this.btn_deconnec.FlatAppearance.BorderSize = 0;
            this.btn_deconnec.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deconnec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_deconnec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deconnec.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_deconnec.ForeColor = System.Drawing.Color.White;
            this.btn_deconnec.Location = new System.Drawing.Point(15, 769);
            this.btn_deconnec.Name = "btn_deconnec";
            this.btn_deconnec.Size = new System.Drawing.Size(179, 57);
            this.btn_deconnec.TabIndex = 9;
            this.btn_deconnec.Text = "Deconnexion";
            this.btn_deconnec.UseVisualStyleBackColor = true;
            this.btn_deconnec.Click += new System.EventHandler(this.btn_deconnec_Click);
            // 
            // btn_produit
            // 
            this.btn_produit.FlatAppearance.BorderSize = 0;
            this.btn_produit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_produit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_produit.ForeColor = System.Drawing.Color.White;
            this.btn_produit.Location = new System.Drawing.Point(12, 458);
            this.btn_produit.Name = "btn_produit";
            this.btn_produit.Size = new System.Drawing.Size(178, 57);
            this.btn_produit.TabIndex = 6;
            this.btn_produit.Text = "Produit";
            this.btn_produit.UseVisualStyleBackColor = true;
            this.btn_produit.Click += new System.EventHandler(this.btn_produit_Click);
            // 
            // btn_fournisseur
            // 
            this.btn_fournisseur.FlatAppearance.BorderSize = 0;
            this.btn_fournisseur.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_fournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fournisseur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_fournisseur.ForeColor = System.Drawing.Color.White;
            this.btn_fournisseur.Location = new System.Drawing.Point(12, 304);
            this.btn_fournisseur.Name = "btn_fournisseur";
            this.btn_fournisseur.Size = new System.Drawing.Size(178, 57);
            this.btn_fournisseur.TabIndex = 5;
            this.btn_fournisseur.Text = "Fournisseur";
            this.btn_fournisseur.UseVisualStyleBackColor = true;
            this.btn_fournisseur.Click += new System.EventHandler(this.btn_fournisseur_Click);
            // 
            // btn_marche
            // 
            this.btn_marche.FlatAppearance.BorderSize = 0;
            this.btn_marche.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_marche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_marche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marche.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_marche.ForeColor = System.Drawing.Color.White;
            this.btn_marche.Location = new System.Drawing.Point(12, 380);
            this.btn_marche.Name = "btn_marche";
            this.btn_marche.Size = new System.Drawing.Size(178, 57);
            this.btn_marche.TabIndex = 4;
            this.btn_marche.Text = "Marche";
            this.btn_marche.UseVisualStyleBackColor = true;
            this.btn_marche.Click += new System.EventHandler(this.btn_marche_Click);
            // 
            // btn_detailcommande
            // 
            this.btn_detailcommande.FlatAppearance.BorderSize = 0;
            this.btn_detailcommande.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_detailcommande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_detailcommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detailcommande.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_detailcommande.ForeColor = System.Drawing.Color.White;
            this.btn_detailcommande.Location = new System.Drawing.Point(12, 220);
            this.btn_detailcommande.Name = "btn_detailcommande";
            this.btn_detailcommande.Size = new System.Drawing.Size(178, 57);
            this.btn_detailcommande.TabIndex = 3;
            this.btn_detailcommande.Text = "Detail Commande";
            this.btn_detailcommande.UseVisualStyleBackColor = true;
            this.btn_detailcommande.Click += new System.EventHandler(this.btn_detailcommande_Click);
            // 
            // btn_commande
            // 
            this.btn_commande.FlatAppearance.BorderSize = 0;
            this.btn_commande.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_commande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commande.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_commande.ForeColor = System.Drawing.Color.White;
            this.btn_commande.Location = new System.Drawing.Point(12, 137);
            this.btn_commande.Name = "btn_commande";
            this.btn_commande.Size = new System.Drawing.Size(178, 57);
            this.btn_commande.TabIndex = 2;
            this.btn_commande.Text = "Commande";
            this.btn_commande.UseVisualStyleBackColor = true;
            this.btn_commande.Click += new System.EventHandler(this.btn_commande_Click);
            // 
            // pnlbat
            // 
            this.pnlbat.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlbat.Location = new System.Drawing.Point(0, 58);
            this.pnlbat.Name = "pnlbat";
            this.pnlbat.Size = new System.Drawing.Size(11, 57);
            this.pnlbat.TabIndex = 1;
            // 
            // btn_client
            // 
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.Location = new System.Drawing.Point(12, 58);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(178, 57);
            this.btn_client.TabIndex = 0;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 49);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Projet_Marche.Properties.Resources.icons8_minimize_window_32;
            this.button3.Location = new System.Drawing.Point(1194, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 25);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Projet_Marche.Properties.Resources.icons8_close_window_32;
            this.button2.Location = new System.Drawing.Point(1230, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 25);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.main.BackgroundImage = global::Projet_Marche.Properties.Resources.marche;
            this.main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main.Controls.Add(this.panel3);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(194, 49);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1261, 845);
            this.main.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 823);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 22);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(1704, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version 1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ready...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 894);
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_client;
        private Panel main;
        private Button button2;
        private Button button3;
        private Button btn_fournisseur;
        private Button btn_marche;
        private Button btn_detailcommande;
        private Button btn_commande;
        private Panel pnlbat;
        private Button btn_produit;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button btn_deconnec;
    }
}