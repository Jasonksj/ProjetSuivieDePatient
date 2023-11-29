using System.Windows.Forms;

namespace Projet_Marche.Views.Commande
{
    partial class FormCommande
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_montant = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.txt_client = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_fournisseur = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fournisseurID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_marche = new Guna.UI2.WinForms.Guna2TextBox();
            this.marcheID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datecommande = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(384, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(360, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "AJOUT D\'UN COMMANDE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Montant";
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
            this.txt_montant.Location = new System.Drawing.Point(735, 113);
            this.txt_montant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.PasswordChar = '\0';
            this.txt_montant.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_montant.PlaceholderText = "";
            this.txt_montant.SelectedText = "";
            this.txt_montant.Size = new System.Drawing.Size(321, 26);
            this.txt_montant.TabIndex = 21;
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
            this.btn_valider.Location = new System.Drawing.Point(755, 385);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_client
            // 
            this.txt_client.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_client.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_client.BorderRadius = 15;
            this.txt_client.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_client.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_client.DefaultText = "";
            this.txt_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_client.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_client.ForeColor = System.Drawing.Color.DimGray;
            this.txt_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_client.Location = new System.Drawing.Point(780, 221);
            this.txt_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_client.Name = "txt_client";
            this.txt_client.PasswordChar = '\0';
            this.txt_client.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_client.PlaceholderText = "";
            this.txt_client.SelectedText = "";
            this.txt_client.Size = new System.Drawing.Size(276, 29);
            this.txt_client.TabIndex = 76;
            // 
            // txt_fournisseur
            // 
            this.txt_fournisseur.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_fournisseur.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_fournisseur.BorderRadius = 15;
            this.txt_fournisseur.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_fournisseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fournisseur.DefaultText = "";
            this.txt_fournisseur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fournisseur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fournisseur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fournisseur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fournisseur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fournisseur.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_fournisseur.ForeColor = System.Drawing.Color.DimGray;
            this.txt_fournisseur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fournisseur.Location = new System.Drawing.Point(780, 167);
            this.txt_fournisseur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fournisseur.Name = "txt_fournisseur";
            this.txt_fournisseur.PasswordChar = '\0';
            this.txt_fournisseur.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_fournisseur.PlaceholderText = "";
            this.txt_fournisseur.SelectedText = "";
            this.txt_fournisseur.Size = new System.Drawing.Size(276, 29);
            this.txt_fournisseur.TabIndex = 75;
            // 
            // clientID
            // 
            this.clientID.FormattingEnabled = true;
            this.clientID.Location = new System.Drawing.Point(735, 231);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(42, 21);
            this.clientID.TabIndex = 74;
            this.clientID.SelectedIndexChanged += new System.EventHandler(this.clientID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Client";
            // 
            // fournisseurID
            // 
            this.fournisseurID.FormattingEnabled = true;
            this.fournisseurID.Location = new System.Drawing.Point(735, 177);
            this.fournisseurID.Name = "fournisseurID";
            this.fournisseurID.Size = new System.Drawing.Size(42, 21);
            this.fournisseurID.TabIndex = 71;
            this.fournisseurID.SelectedIndexChanged += new System.EventHandler(this.fournisseurID_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(625, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 70;
            this.label10.Text = "Fournisseur";
            // 
            // txt_marche
            // 
            this.txt_marche.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_marche.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_marche.BorderRadius = 15;
            this.txt_marche.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_marche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_marche.DefaultText = "";
            this.txt_marche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_marche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_marche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_marche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_marche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_marche.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_marche.ForeColor = System.Drawing.Color.DimGray;
            this.txt_marche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_marche.Location = new System.Drawing.Point(780, 272);
            this.txt_marche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_marche.Name = "txt_marche";
            this.txt_marche.PasswordChar = '\0';
            this.txt_marche.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_marche.PlaceholderText = "";
            this.txt_marche.SelectedText = "";
            this.txt_marche.Size = new System.Drawing.Size(276, 29);
            this.txt_marche.TabIndex = 80;
            // 
            // marcheID
            // 
            this.marcheID.FormattingEnabled = true;
            this.marcheID.Location = new System.Drawing.Point(735, 282);
            this.marcheID.Name = "marcheID";
            this.marcheID.Size = new System.Drawing.Size(42, 21);
            this.marcheID.TabIndex = 79;
            this.marcheID.SelectedIndexChanged += new System.EventHandler(this.marcheID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 78;
            this.label4.Text = "Marche";
            // 
            // datecommande
            // 
            this.datecommande.Location = new System.Drawing.Point(735, 73);
            this.datecommande.Name = "datecommande";
            this.datecommande.Size = new System.Drawing.Size(321, 20);
            this.datecommande.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 82;
            this.label5.Text = "Date Commande";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_Marche.Properties.Resources.commande;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1086, 511);
            this.Controls.Add(this.datecommande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_marche);
            this.Controls.Add(this.marcheID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_client);
            this.Controls.Add(this.txt_fournisseur);
            this.Controls.Add(this.clientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fournisseurID);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_montant);
            this.Controls.Add(this.titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label titre;
        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_montant;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_client;
        private Guna.UI2.WinForms.Guna2TextBox txt_fournisseur;
        private ComboBox clientID;
        private Label label2;
        private ComboBox fournisseurID;
        private Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_marche;
        private ComboBox marcheID;
        private Label label4;
        private DateTimePicker datecommande;
        private Label label5;
    }
}