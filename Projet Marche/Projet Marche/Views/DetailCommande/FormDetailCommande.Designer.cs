using System.Windows.Forms;

namespace Projet_Marche.Views.DetailCommande
{
    partial class FormDetailCommande
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
            this.titre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_prix = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_produit = new Guna.UI2.WinForms.Guna2TextBox();
            this.produitID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_commande = new Guna.UI2.WinForms.Guna2TextBox();
            this.commandeID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_montant = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(340, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(532, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "AJOUT DU DETAIL D\'UNE COMMANDE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(722, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quantite";
            // 
            // txt_quantite
            // 
            this.txt_quantite.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_quantite.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_quantite.BorderRadius = 15;
            this.txt_quantite.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_quantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantite.DefaultText = "";
            this.txt_quantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantite.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_quantite.ForeColor = System.Drawing.Color.DimGray;
            this.txt_quantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantite.Location = new System.Drawing.Point(807, 202);
            this.txt_quantite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.PasswordChar = '\0';
            this.txt_quantite.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_quantite.PlaceholderText = "";
            this.txt_quantite.SelectedText = "";
            this.txt_quantite.Size = new System.Drawing.Size(321, 26);
            this.txt_quantite.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(692, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Prix Unitaire";
            // 
            // txt_prix
            // 
            this.txt_prix.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_prix.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_prix.BorderRadius = 15;
            this.txt_prix.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prix.DefaultText = "";
            this.txt_prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prix.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_prix.ForeColor = System.Drawing.Color.DimGray;
            this.txt_prix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prix.Location = new System.Drawing.Point(807, 274);
            this.txt_prix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.PasswordChar = '\0';
            this.txt_prix.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_prix.PlaceholderText = "";
            this.txt_prix.SelectedText = "";
            this.txt_prix.Size = new System.Drawing.Size(321, 26);
            this.txt_prix.TabIndex = 21;
            // 
            // btn_valider
            // 
            this.btn_valider.BorderRadius = 15;
            this.btn_valider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_valider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_valider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_valider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_valider.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.Color.White;
            this.btn_valider.Location = new System.Drawing.Point(836, 424);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_Marche.Properties.Resources.detailCommande;
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // txt_produit
            // 
            this.txt_produit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_produit.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_produit.BorderRadius = 15;
            this.txt_produit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_produit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_produit.DefaultText = "";
            this.txt_produit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_produit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_produit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_produit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_produit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_produit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_produit.ForeColor = System.Drawing.Color.DimGray;
            this.txt_produit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_produit.Location = new System.Drawing.Point(852, 130);
            this.txt_produit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_produit.Name = "txt_produit";
            this.txt_produit.PasswordChar = '\0';
            this.txt_produit.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_produit.PlaceholderText = "";
            this.txt_produit.SelectedText = "";
            this.txt_produit.Size = new System.Drawing.Size(276, 29);
            this.txt_produit.TabIndex = 88;
            // 
            // produitID
            // 
            this.produitID.FormattingEnabled = true;
            this.produitID.Location = new System.Drawing.Point(807, 140);
            this.produitID.Name = "produitID";
            this.produitID.Size = new System.Drawing.Size(42, 21);
            this.produitID.TabIndex = 87;
            this.produitID.SelectedIndexChanged += new System.EventHandler(this.produitID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 86;
            this.label4.Text = "Produit";
            // 
            // txt_commande
            // 
            this.txt_commande.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_commande.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_commande.BorderRadius = 15;
            this.txt_commande.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_commande.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_commande.DefaultText = "";
            this.txt_commande.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_commande.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_commande.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_commande.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_commande.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_commande.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_commande.ForeColor = System.Drawing.Color.DimGray;
            this.txt_commande.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_commande.Location = new System.Drawing.Point(852, 79);
            this.txt_commande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_commande.Name = "txt_commande";
            this.txt_commande.PasswordChar = '\0';
            this.txt_commande.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_commande.PlaceholderText = "";
            this.txt_commande.SelectedText = "";
            this.txt_commande.Size = new System.Drawing.Size(276, 29);
            this.txt_commande.TabIndex = 84;
            // 
            // commandeID
            // 
            this.commandeID.FormattingEnabled = true;
            this.commandeID.Location = new System.Drawing.Point(807, 89);
            this.commandeID.Name = "commandeID";
            this.commandeID.Size = new System.Drawing.Size(42, 21);
            this.commandeID.TabIndex = 83;
            this.commandeID.SelectedIndexChanged += new System.EventHandler(this.commandeID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "Montant";
            // 
            // txt_montant
            // 
            this.txt_montant.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_montant.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_montant.BorderRadius = 15;
            this.txt_montant.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_montant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_montant.DefaultText = "";
            this.txt_montant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_montant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_montant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_montant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_montant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_montant.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_montant.ForeColor = System.Drawing.Color.DimGray;
            this.txt_montant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_montant.Location = new System.Drawing.Point(807, 343);
            this.txt_montant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.PasswordChar = '\0';
            this.txt_montant.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_montant.PlaceholderText = "";
            this.txt_montant.SelectedText = "";
            this.txt_montant.Size = new System.Drawing.Size(321, 26);
            this.txt_montant.TabIndex = 89;
            // 
            // FormDetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1163, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_montant);
            this.Controls.Add(this.txt_produit);
            this.Controls.Add(this.produitID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_commande);
            this.Controls.Add(this.commandeID);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_quantite);
            this.Controls.Add(this.titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDetailCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormDetailCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label titre;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantite;
        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_prix;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_produit;
        private ComboBox produitID;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_commande;
        private ComboBox commandeID;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_montant;
    }
}