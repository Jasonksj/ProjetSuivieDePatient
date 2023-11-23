using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Prescription
{
    partial class FormPrescription
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
            this.button2 = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_valider = new Guna.UI2.WinForms.Guna2Button();
            this.dateNaiss = new System.Windows.Forms.DateTimePicker();
            this.medecinID = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.patientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_resultat = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(480, 9);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(320, 34);
            this.titre.TabIndex = 5;
            this.titre.Text = "Ajout d\'une prescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de la prescription";
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
            this.label6.Location = new System.Drawing.Point(692, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Posologie Generale";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(748, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Medecin";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel9.Location = new System.Drawing.Point(853, 277);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 3);
            this.panel9.TabIndex = 28;
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
            this.btn_valider.Location = new System.Drawing.Point(853, 416);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(154, 37);
            this.btn_valider.TabIndex = 34;
            this.btn_valider.Text = "Valider";
            // 
            // dateNaiss
            // 
            this.dateNaiss.Location = new System.Drawing.Point(853, 79);
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.Size = new System.Drawing.Size(321, 20);
            this.dateNaiss.TabIndex = 35;
            // 
            // medecinID
            // 
            this.medecinID.FormattingEnabled = true;
            this.medecinID.Location = new System.Drawing.Point(853, 257);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetSuiviePatient.Properties.Resources.Prescription;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
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
            // patientID
            // 
            this.patientID.FormattingEnabled = true;
            this.patientID.Location = new System.Drawing.Point(853, 311);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(321, 21);
            this.patientID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(853, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 3);
            this.panel1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Instructions";
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
            // FormPrescription
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
            this.Controls.Add(this.dateNaiss);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrescription";
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
        private Label label10;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_valider;
        private DateTimePicker dateNaiss;
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