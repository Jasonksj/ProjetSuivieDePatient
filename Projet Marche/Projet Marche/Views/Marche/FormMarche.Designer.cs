using System.Windows.Forms;

namespace Projet_Marche.Views.Marche
{
    partial class FormMarche
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
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(414, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(307, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "AJOUT D\'UN MARCHE";
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
            this.btn_valider.Location = new System.Drawing.Point(832, 392);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_Marche.Properties.Resources.marche;
            this.pictureBox1.Location = new System.Drawing.Point(9, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_description.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_description.BorderRadius = 15;
            this.txt_description.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.DefaultText = "";
            this.txt_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_description.ForeColor = System.Drawing.Color.DimGray;
            this.txt_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.Location = new System.Drawing.Point(783, 300);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_description.PlaceholderText = "";
            this.txt_description.SelectedText = "";
            this.txt_description.Size = new System.Drawing.Size(321, 31);
            this.txt_description.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Description";
            // 
            // txt_adresse
            // 
            this.txt_adresse.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_adresse.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_adresse.BorderRadius = 15;
            this.txt_adresse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adresse.DefaultText = "";
            this.txt_adresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_adresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_adresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_adresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_adresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_adresse.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_adresse.ForeColor = System.Drawing.Color.DimGray;
            this.txt_adresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_adresse.Location = new System.Drawing.Point(783, 245);
            this.txt_adresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.PasswordChar = '\0';
            this.txt_adresse.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_adresse.PlaceholderText = "";
            this.txt_adresse.SelectedText = "";
            this.txt_adresse.Size = new System.Drawing.Size(321, 31);
            this.txt_adresse.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Adresse";
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
            this.txt_nom.Location = new System.Drawing.Point(783, 195);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.Size = new System.Drawing.Size(321, 31);
            this.txt_nom.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "Nom";
            // 
            // FormMarche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1129, 572);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMarche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormMarche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label titre;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Guna.UI2.WinForms.Guna2TextBox txt_description;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_adresse;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
        private Label label3;
    }
}