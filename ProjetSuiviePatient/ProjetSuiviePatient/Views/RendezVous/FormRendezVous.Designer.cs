using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.RendezVous
{
    partial class FormRendezVous
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_motif = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_remarque = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_urgence = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.daterendezvous = new System.Windows.Forms.DateTimePicker();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_statut = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_patient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_medecin = new Guna.UI2.WinForms.Guna2TextBox();
            this.patientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.medecinID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(492, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(302, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "Ajout d\'un rendez vous";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date et Heure";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(853, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 3);
            this.panel3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(771, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Motif";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(853, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 3);
            this.panel5.TabIndex = 16;
            // 
            // txt_motif
            // 
            this.txt_motif.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_motif.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_motif.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_motif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_motif.DefaultText = "";
            this.txt_motif.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_motif.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_motif.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_motif.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_motif.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_motif.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_motif.ForeColor = System.Drawing.Color.DimGray;
            this.txt_motif.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_motif.Location = new System.Drawing.Point(853, 241);
            this.txt_motif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_motif.Multiline = true;
            this.txt_motif.Name = "txt_motif";
            this.txt_motif.PasswordChar = '\0';
            this.txt_motif.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_motif.PlaceholderText = "";
            this.txt_motif.SelectedText = "";
            this.txt_motif.Size = new System.Drawing.Size(321, 70);
            this.txt_motif.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(739, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Remarques";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(853, 423);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 3);
            this.panel6.TabIndex = 19;
            // 
            // txt_remarque
            // 
            this.txt_remarque.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_remarque.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_remarque.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_remarque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_remarque.DefaultText = "";
            this.txt_remarque.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_remarque.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_remarque.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_remarque.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_remarque.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_remarque.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_remarque.ForeColor = System.Drawing.Color.DimGray;
            this.txt_remarque.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_remarque.Location = new System.Drawing.Point(853, 396);
            this.txt_remarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_remarque.Name = "txt_remarque";
            this.txt_remarque.PasswordChar = '\0';
            this.txt_remarque.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_remarque.PlaceholderText = "";
            this.txt_remarque.SelectedText = "";
            this.txt_remarque.Size = new System.Drawing.Size(321, 26);
            this.txt_remarque.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(761, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Urgence";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel10.Location = new System.Drawing.Point(853, 482);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(321, 3);
            this.panel10.TabIndex = 31;
            // 
            // txt_urgence
            // 
            this.txt_urgence.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_urgence.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_urgence.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_urgence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_urgence.DefaultText = "";
            this.txt_urgence.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_urgence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_urgence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_urgence.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_urgence.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_urgence.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_urgence.ForeColor = System.Drawing.Color.DimGray;
            this.txt_urgence.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_urgence.Location = new System.Drawing.Point(853, 458);
            this.txt_urgence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urgence.Name = "txt_urgence";
            this.txt_urgence.PasswordChar = '\0';
            this.txt_urgence.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_urgence.PlaceholderText = "";
            this.txt_urgence.SelectedText = "";
            this.txt_urgence.Size = new System.Drawing.Size(321, 29);
            this.txt_urgence.TabIndex = 30;
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
            this.btn_valider.Location = new System.Drawing.Point(549, 523);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // daterendezvous
            // 
            this.daterendezvous.Location = new System.Drawing.Point(853, 79);
            this.daterendezvous.Name = "daterendezvous";
            this.daterendezvous.Size = new System.Drawing.Size(321, 20);
            this.daterendezvous.TabIndex = 35;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1229, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 595);
            this.panel13.TabIndex = 42;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 592);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1229, 3);
            this.panel14.TabIndex = 43;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1226, 3);
            this.panel15.TabIndex = 44;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(3, 592);
            this.panel16.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Statut";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(853, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 3);
            this.panel2.TabIndex = 49;
            // 
            // txt_statut
            // 
            this.txt_statut.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_statut.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_statut.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_statut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_statut.DefaultText = "";
            this.txt_statut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_statut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_statut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_statut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_statut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_statut.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_statut.ForeColor = System.Drawing.Color.DimGray;
            this.txt_statut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_statut.Location = new System.Drawing.Point(853, 340);
            this.txt_statut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_statut.Name = "txt_statut";
            this.txt_statut.PasswordChar = '\0';
            this.txt_statut.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_statut.PlaceholderText = "";
            this.txt_statut.SelectedText = "";
            this.txt_statut.Size = new System.Drawing.Size(321, 26);
            this.txt_statut.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetSuiviePatient.Properties.Resources.RendezVous;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 445);
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
            this.button2.Location = new System.Drawing.Point(1181, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjetSuiviePatient.Properties.Resources.icons8_close_window_32;
            this.button1.Location = new System.Drawing.Point(1208, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_patient
            // 
            this.txt_patient.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_patient.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_patient.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_patient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_patient.DefaultText = "";
            this.txt_patient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_patient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_patient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_patient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_patient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_patient.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_patient.ForeColor = System.Drawing.Color.DimGray;
            this.txt_patient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_patient.Location = new System.Drawing.Point(898, 174);
            this.txt_patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_patient.Name = "txt_patient";
            this.txt_patient.PasswordChar = '\0';
            this.txt_patient.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_patient.PlaceholderText = "";
            this.txt_patient.SelectedText = "";
            this.txt_patient.Size = new System.Drawing.Size(276, 29);
            this.txt_patient.TabIndex = 68;
            // 
            // txt_medecin
            // 
            this.txt_medecin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_medecin.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_medecin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_medecin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_medecin.DefaultText = "";
            this.txt_medecin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_medecin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_medecin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_medecin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_medecin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_medecin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_medecin.ForeColor = System.Drawing.Color.DimGray;
            this.txt_medecin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_medecin.Location = new System.Drawing.Point(898, 120);
            this.txt_medecin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_medecin.Name = "txt_medecin";
            this.txt_medecin.PasswordChar = '\0';
            this.txt_medecin.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_medecin.PlaceholderText = "";
            this.txt_medecin.SelectedText = "";
            this.txt_medecin.Size = new System.Drawing.Size(276, 29);
            this.txt_medecin.TabIndex = 67;
            // 
            // patientID
            // 
            this.patientID.FormattingEnabled = true;
            this.patientID.Location = new System.Drawing.Point(853, 184);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(42, 21);
            this.patientID.TabIndex = 66;
            this.patientID.SelectedIndexChanged += new System.EventHandler(this.patientID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(853, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 3);
            this.panel1.TabIndex = 64;
            // 
            // medecinID
            // 
            this.medecinID.FormattingEnabled = true;
            this.medecinID.Location = new System.Drawing.Point(853, 130);
            this.medecinID.Name = "medecinID";
            this.medecinID.Size = new System.Drawing.Size(42, 21);
            this.medecinID.TabIndex = 63;
            this.medecinID.SelectedIndexChanged += new System.EventHandler(this.medecinID_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(748, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Medecin";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel9.Location = new System.Drawing.Point(853, 150);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 3);
            this.panel9.TabIndex = 61;
            // 
            // FormRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1232, 595);
            this.Controls.Add(this.txt_patient);
            this.Controls.Add(this.txt_medecin);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medecinID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_statut);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.daterendezvous);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txt_urgence);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_remarque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_motif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRendezVous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatient";
            this.Load += new System.EventHandler(this.FormRendezVous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label titre;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_motif;
        private Label label7;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_remarque;
        private Label label11;
        private Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_urgence;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private DateTimePicker daterendezvous;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Label label2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_statut;
        private Guna.UI2.WinForms.Guna2TextBox txt_patient;
        private Guna.UI2.WinForms.Guna2TextBox txt_medecin;
        private ComboBox patientID;
        private Label label1;
        private Panel panel1;
        private ComboBox medecinID;
        private Label label10;
        private Panel panel9;
    }
}