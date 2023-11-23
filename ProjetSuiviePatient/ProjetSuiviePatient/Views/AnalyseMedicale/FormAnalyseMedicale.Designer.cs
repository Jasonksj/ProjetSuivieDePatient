using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.AnalyseMedicale
{
    partial class FormAnalyseMedicale
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
            this.txt_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_labo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_commentaire = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.dateAnalyse = new System.Windows.Forms.DateTimePicker();
            this.medecinID = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.patientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_resultat = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(344, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(390, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "Ajout d\'une analyse medicale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(718, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date d\'analyse";
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
            this.label6.Location = new System.Drawing.Point(714, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Type d\'analyse";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(853, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 3);
            this.panel5.TabIndex = 16;
            // 
            // txt_type
            // 
            this.txt_type.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_type.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_type.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_type.DefaultText = "";
            this.txt_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_type.ForeColor = System.Drawing.Color.DimGray;
            this.txt_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Location = new System.Drawing.Point(853, 135);
            this.txt_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_type.Name = "txt_type";
            this.txt_type.PasswordChar = '\0';
            this.txt_type.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_type.PlaceholderText = "";
            this.txt_type.SelectedText = "";
            this.txt_type.Size = new System.Drawing.Size(321, 26);
            this.txt_type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(739, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Laboratoire";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(853, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 3);
            this.panel6.TabIndex = 19;
            // 
            // txt_labo
            // 
            this.txt_labo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_labo.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_labo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_labo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_labo.DefaultText = "";
            this.txt_labo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_labo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_labo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_labo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_labo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_labo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_labo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_labo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_labo.Location = new System.Drawing.Point(853, 237);
            this.txt_labo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_labo.Name = "txt_labo";
            this.txt_labo.PasswordChar = '\0';
            this.txt_labo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_labo.PlaceholderText = "";
            this.txt_labo.SelectedText = "";
            this.txt_labo.Size = new System.Drawing.Size(321, 26);
            this.txt_labo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(748, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Medecin";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel9.Location = new System.Drawing.Point(853, 377);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 3);
            this.panel9.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(640, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Commentaires Resultat";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel10.Location = new System.Drawing.Point(853, 311);
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
            this.txt_commentaire.Location = new System.Drawing.Point(853, 287);
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
            this.btn_valider.Location = new System.Drawing.Point(596, 522);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            // 
            // dateAnalyse
            // 
            this.dateAnalyse.Location = new System.Drawing.Point(853, 79);
            this.dateAnalyse.Name = "dateAnalyse";
            this.dateAnalyse.Size = new System.Drawing.Size(321, 20);
            this.dateAnalyse.TabIndex = 35;
            // 
            // medecinID
            // 
            this.medecinID.FormattingEnabled = true;
            this.medecinID.Location = new System.Drawing.Point(853, 357);
            this.medecinID.Name = "medecinID";
            this.medecinID.Size = new System.Drawing.Size(321, 21);
            this.medecinID.TabIndex = 38;
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
            // patientID
            // 
            this.patientID.FormattingEnabled = true;
            this.patientID.Location = new System.Drawing.Point(853, 411);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(321, 21);
            this.patientID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(853, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 3);
            this.panel1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(762, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Resultat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(853, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 3);
            this.panel2.TabIndex = 49;
            // 
            // txt_resultat
            // 
            this.txt_resultat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_resultat.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_resultat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txt_resultat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_resultat.DefaultText = "";
            this.txt_resultat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_resultat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_resultat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_resultat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_resultat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_resultat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_resultat.ForeColor = System.Drawing.Color.DimGray;
            this.txt_resultat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_resultat.Location = new System.Drawing.Point(853, 190);
            this.txt_resultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_resultat.Name = "txt_resultat";
            this.txt_resultat.PasswordChar = '\0';
            this.txt_resultat.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_resultat.PlaceholderText = "";
            this.txt_resultat.SelectedText = "";
            this.txt_resultat.Size = new System.Drawing.Size(321, 26);
            this.txt_resultat.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetSuiviePatient.Properties.Resources.AnalyseMedicale;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 445);
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
            // 
            // FormAnalyseMedicale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1232, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_resultat);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.medecinID);
            this.Controls.Add(this.dateAnalyse);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txt_commentaire);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_labo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnalyseMedicale";
            this.Text = "FormPatient";
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
        private Guna.UI2.WinForms.Guna2TextBox txt_type;
        private Label label7;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_labo;
        private Label label10;
        private Panel panel9;
        private Label label11;
        private Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox txt_commentaire;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private DateTimePicker dateAnalyse;
        private ComboBox medecinID;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private ComboBox patientID;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_resultat;
    }
}