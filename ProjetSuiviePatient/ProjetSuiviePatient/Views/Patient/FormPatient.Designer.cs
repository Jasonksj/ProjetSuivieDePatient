using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Patient
{
    partial class FormPatient
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_adresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_tel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_commentaire = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.dateNaiss = new System.Windows.Forms.DateTimePicker();
            this.dervisite = new System.Windows.Forms.DateTimePicker();
            this.groupsanguin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_assurance = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_sexe = new System.Windows.Forms.ComboBox();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(411, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 34);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "AJOUT D\'UN PATIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(735, 140);
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
            this.txt_prenom.Location = new System.Drawing.Point(735, 114);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PasswordChar = '\0';
            this.txt_prenom.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_prenom.PlaceholderText = "";
            this.txt_prenom.SelectedText = "";
            this.txt_prenom.Size = new System.Drawing.Size(321, 26);
            this.txt_prenom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de naissance";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(735, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 3);
            this.panel3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sexe";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(735, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 3);
            this.panel4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(646, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adresse";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(735, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 3);
            this.panel5.TabIndex = 16;
            // 
            // txt_adresse
            // 
            this.txt_adresse.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_adresse.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.txt_adresse.Location = new System.Drawing.Point(735, 320);
            this.txt_adresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.PasswordChar = '\0';
            this.txt_adresse.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_adresse.PlaceholderText = "";
            this.txt_adresse.SelectedText = "";
            this.txt_adresse.Size = new System.Drawing.Size(321, 26);
            this.txt_adresse.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Telephone";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(735, 418);
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
            this.txt_tel.Location = new System.Drawing.Point(735, 391);
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
            this.label8.Location = new System.Drawing.Point(666, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Email";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel7.Location = new System.Drawing.Point(735, 490);
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
            this.txt_email.Location = new System.Drawing.Point(735, 463);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(321, 26);
            this.txt_email.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Derniere Visite";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel8.Location = new System.Drawing.Point(180, 552);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 3);
            this.panel8.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 613);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Groupe Sanguin";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel9.Location = new System.Drawing.Point(180, 631);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 3);
            this.panel9.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(522, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Commentaires Medicaux";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel10.Location = new System.Drawing.Point(735, 627);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(321, 3);
            this.panel10.TabIndex = 31;
            // 
            // txt_commentaire
            // 
            this.txt_commentaire.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_commentaire.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_commentaire.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_commentaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_commentaire.DefaultText = "";
            this.txt_commentaire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_commentaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_commentaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_commentaire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_commentaire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_commentaire.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_commentaire.ForeColor = System.Drawing.Color.DimGray;
            this.txt_commentaire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_commentaire.Location = new System.Drawing.Point(735, 603);
            this.txt_commentaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_commentaire.Name = "txt_commentaire";
            this.txt_commentaire.PasswordChar = '\0';
            this.txt_commentaire.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_commentaire.PlaceholderText = "";
            this.txt_commentaire.SelectedText = "";
            this.txt_commentaire.Size = new System.Drawing.Size(321, 29);
            this.txt_commentaire.TabIndex = 30;
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
            this.btn_valider.Location = new System.Drawing.Point(487, 677);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // dateNaiss
            // 
            this.dateNaiss.Location = new System.Drawing.Point(735, 188);
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.Size = new System.Drawing.Size(321, 20);
            this.dateNaiss.TabIndex = 35;
            // 
            // dervisite
            // 
            this.dervisite.Location = new System.Drawing.Point(180, 531);
            this.dervisite.Name = "dervisite";
            this.dervisite.Size = new System.Drawing.Size(321, 20);
            this.dervisite.TabIndex = 37;
            // 
            // groupsanguin
            // 
            this.groupsanguin.FormattingEnabled = true;
            this.groupsanguin.Items.AddRange(new object[] {
            "Groupe A",
            "Groupe B",
            "Groupe AB",
            "Groupe O"});
            this.groupsanguin.Location = new System.Drawing.Point(180, 611);
            this.groupsanguin.Name = "groupsanguin";
            this.groupsanguin.Size = new System.Drawing.Size(321, 21);
            this.groupsanguin.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Numero Assurance";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel12.Location = new System.Drawing.Point(735, 551);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(321, 3);
            this.panel12.TabIndex = 40;
            // 
            // txt_assurance
            // 
            this.txt_assurance.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_assurance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_assurance.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_assurance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_assurance.DefaultText = "";
            this.txt_assurance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_assurance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_assurance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_assurance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_assurance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_assurance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_assurance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_assurance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_assurance.Location = new System.Drawing.Point(735, 525);
            this.txt_assurance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_assurance.Name = "txt_assurance";
            this.txt_assurance.PasswordChar = '\0';
            this.txt_assurance.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_assurance.PlaceholderText = "";
            this.txt_assurance.SelectedText = "";
            this.txt_assurance.Size = new System.Drawing.Size(321, 26);
            this.txt_assurance.TabIndex = 39;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1083, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 749);
            this.panel13.TabIndex = 42;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 746);
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
            this.panel16.Size = new System.Drawing.Size(3, 746);
            this.panel16.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetSuiviePatient.Properties.Resources.Patient2;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 445);
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
            // txt_sexe
            // 
            this.txt_sexe.FormattingEnabled = true;
            this.txt_sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.txt_sexe.Location = new System.Drawing.Point(735, 255);
            this.txt_sexe.Name = "txt_sexe";
            this.txt_sexe.Size = new System.Drawing.Size(324, 21);
            this.txt_sexe.TabIndex = 45;
            // 
            // FormPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1086, 749);
            this.Controls.Add(this.txt_sexe);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txt_assurance);
            this.Controls.Add(this.groupsanguin);
            this.Controls.Add(this.dervisite);
            this.Controls.Add(this.dateNaiss);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txt_commentaire);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPatient";
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormPatient_Load);
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
        private Label lblTitle;
        private Label label3;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_prenom;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_adresse;
        private Label label7;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_tel;
        private Label label8;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Label label9;
        private Panel panel8;
        private Label label10;
        private Panel panel9;
        private Label label11;
        private Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_commentaire;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private DateTimePicker dateNaiss;
        private DateTimePicker dervisite;
        private ComboBox groupsanguin;
        private Label label2;
        private Panel panel12;
        private Guna.UI2.WinForms.Guna2TextBox txt_assurance;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private ComboBox txt_sexe;
    }
}