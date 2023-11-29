using System.Windows.Forms;

namespace Projet_Marche.Views.Produit
{
    partial class FormProduit
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
            this.txt_prix = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_stock = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(300, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(313, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "AJOUT D\'UN PRODUIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Prix";
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
            this.txt_prix.Location = new System.Drawing.Point(499, 198);
            this.txt_prix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.PasswordChar = '\0';
            this.txt_prix.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_prix.PlaceholderText = "";
            this.txt_prix.SelectedText = "";
            this.txt_prix.Size = new System.Drawing.Size(321, 26);
            this.txt_prix.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_stock.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_stock.BorderRadius = 15;
            this.txt_stock.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stock.DefaultText = "";
            this.txt_stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stock.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_stock.ForeColor = System.Drawing.Color.DimGray;
            this.txt_stock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stock.Location = new System.Drawing.Point(499, 260);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.PasswordChar = '\0';
            this.txt_stock.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_stock.PlaceholderText = "";
            this.txt_stock.SelectedText = "";
            this.txt_stock.Size = new System.Drawing.Size(321, 29);
            this.txt_stock.TabIndex = 30;
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
            this.btn_valider.Location = new System.Drawing.Point(554, 361);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nom";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nom.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nom.BorderRadius = 15;
            this.txt_nom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.DefaultText = "";
            this.txt_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_nom.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom.Location = new System.Drawing.Point(499, 142);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.Size = new System.Drawing.Size(321, 26);
            this.txt_nom.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_Marche.Properties.Resources.produit;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label titre;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_prix;
        private Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_stock;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
    }
}