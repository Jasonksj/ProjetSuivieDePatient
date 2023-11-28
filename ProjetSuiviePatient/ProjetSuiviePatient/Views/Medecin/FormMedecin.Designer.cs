using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Medecin
{
    partial class FormMedecin
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
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_specialite = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_tel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_disponibilité = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_certification = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_anneeExp = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nom.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.txt_nom.Location = new System.Drawing.Point(735, 56);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.Size = new System.Drawing.Size(321, 26);
            this.txt_nom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(735, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 3);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(384, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(321, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "AJOUT D\'UN MEDECIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(735, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 3);
            this.panel2.TabIndex = 7;
            // 
            // txt_prenom
            // 
            this.txt_prenom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_prenom.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_prenom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prenom.DefaultText = "";
            this.txt_prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prenom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_prenom.ForeColor = System.Drawing.Color.DimGray;
            this.txt_prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_prenom.Location = new System.Drawing.Point(735, 123);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PasswordChar = '\0';
            this.txt_prenom.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_prenom.PlaceholderText = "";
            this.txt_prenom.SelectedText = "";
            this.txt_prenom.Size = new System.Drawing.Size(321, 26);
            this.txt_prenom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Specialité";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(735, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 3);
            this.panel5.TabIndex = 16;
            // 
            // txt_specialite
            // 
            this.txt_specialite.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_specialite.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_specialite.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_specialite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_specialite.DefaultText = "";
            this.txt_specialite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_specialite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_specialite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_specialite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_specialite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_specialite.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_specialite.ForeColor = System.Drawing.Color.DimGray;
            this.txt_specialite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_specialite.Location = new System.Drawing.Point(735, 189);
            this.txt_specialite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_specialite.Name = "txt_specialite";
            this.txt_specialite.PasswordChar = '\0';
            this.txt_specialite.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_specialite.PlaceholderText = "";
            this.txt_specialite.SelectedText = "";
            this.txt_specialite.Size = new System.Drawing.Size(321, 26);
            this.txt_specialite.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Telephone";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(735, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 3);
            this.panel6.TabIndex = 19;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_tel.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tel.DefaultText = "";
            this.txt_tel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_tel.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tel.Location = new System.Drawing.Point(735, 260);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PasswordChar = '\0';
            this.txt_tel.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.SelectedText = "";
            this.txt_tel.Size = new System.Drawing.Size(321, 26);
            this.txt_tel.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(666, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel7.Location = new System.Drawing.Point(735, 359);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 3);
            this.panel7.TabIndex = 22;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_email.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(735, 332);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(321, 26);
            this.txt_email.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(614, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Disponibilité";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel10.Location = new System.Drawing.Point(735, 533);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(321, 3);
            this.panel10.TabIndex = 31;
            // 
            // txt_disponibilité
            // 
            this.txt_disponibilité.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_disponibilité.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_disponibilité.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_disponibilité.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_disponibilité.DefaultText = "";
            this.txt_disponibilité.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_disponibilité.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_disponibilité.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_disponibilité.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_disponibilité.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_disponibilité.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_disponibilité.ForeColor = System.Drawing.Color.DimGray;
            this.txt_disponibilité.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_disponibilité.Location = new System.Drawing.Point(735, 509);
            this.txt_disponibilité.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_disponibilité.Name = "txt_disponibilité";
            this.txt_disponibilité.PasswordChar = '\0';
            this.txt_disponibilité.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_disponibilité.PlaceholderText = "";
            this.txt_disponibilité.SelectedText = "";
            this.txt_disponibilité.Size = new System.Drawing.Size(321, 29);
            this.txt_disponibilité.TabIndex = 30;
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
            this.btn_valider.Location = new System.Drawing.Point(456, 565);
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
            this.label2.Location = new System.Drawing.Point(616, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Certification";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel12.Location = new System.Drawing.Point(735, 477);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(321, 3);
            this.panel12.TabIndex = 40;
            // 
            // txt_certification
            // 
            this.txt_certification.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_certification.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_certification.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_certification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_certification.DefaultText = "";
            this.txt_certification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_certification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_certification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_certification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_certification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_certification.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_certification.ForeColor = System.Drawing.Color.DimGray;
            this.txt_certification.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_certification.Location = new System.Drawing.Point(735, 451);
            this.txt_certification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_certification.Name = "txt_certification";
            this.txt_certification.PasswordChar = '\0';
            this.txt_certification.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_certification.PlaceholderText = "";
            this.txt_certification.SelectedText = "";
            this.txt_certification.Size = new System.Drawing.Size(321, 26);
            this.txt_certification.TabIndex = 39;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1083, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 614);
            this.panel13.TabIndex = 42;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 611);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1083, 3);
            this.panel14.TabIndex = 43;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1080, 3);
            this.panel15.TabIndex = 44;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(3, 611);
            this.panel16.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetSuiviePatient.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ProjetSuiviePatient.Properties.Resources.icons8_minimize_window_32;
            this.button2.Location = new System.Drawing.Point(1035, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjetSuiviePatient.Properties.Resources.icons8_close_window_32;
            this.button1.Location = new System.Drawing.Point(1062, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Annee Exp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(735, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 3);
            this.panel3.TabIndex = 46;
            // 
            // txt_anneeExp
            // 
            this.txt_anneeExp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_anneeExp.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_anneeExp.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_anneeExp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_anneeExp.DefaultText = "";
            this.txt_anneeExp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_anneeExp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_anneeExp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_anneeExp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_anneeExp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_anneeExp.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_anneeExp.ForeColor = System.Drawing.Color.DimGray;
            this.txt_anneeExp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_anneeExp.Location = new System.Drawing.Point(735, 394);
            this.txt_anneeExp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_anneeExp.Name = "txt_anneeExp";
            this.txt_anneeExp.PasswordChar = '\0';
            this.txt_anneeExp.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_anneeExp.PlaceholderText = "";
            this.txt_anneeExp.SelectedText = "";
            this.txt_anneeExp.Size = new System.Drawing.Size(321, 26);
            this.txt_anneeExp.TabIndex = 45;
            // 
            // FormMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1086, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_anneeExp);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txt_certification);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txt_disponibilité);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_specialite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMedecin";
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
        private Panel panel1;
        private Label label1;
        private Label titre;
        private Label label3;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_prenom;
        private Label label6;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_specialite;
        private Label label7;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_tel;
        private Label label8;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Label label11;
        private Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_disponibilité;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private Label label2;
        private Panel panel12;
        private Guna.UI2.WinForms.Guna2TextBox txt_certification;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Label label4;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_anneeExp;
    }
}