using System.Drawing;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views
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
            this.btn_medicament = new System.Windows.Forms.Button();
            this.btn_rendezvous = new System.Windows.Forms.Button();
            this.btn_antecedent = new System.Windows.Forms.Button();
            this.btn_prescription = new System.Windows.Forms.Button();
            this.btn_analyse = new System.Windows.Forms.Button();
            this.btn_medecin = new System.Windows.Forms.Button();
            this.pnlbat = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_patient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_deconnec);
            this.panel1.Controls.Add(this.btn_medicament);
            this.panel1.Controls.Add(this.btn_rendezvous);
            this.panel1.Controls.Add(this.btn_antecedent);
            this.panel1.Controls.Add(this.btn_prescription);
            this.panel1.Controls.Add(this.btn_analyse);
            this.panel1.Controls.Add(this.btn_medecin);
            this.panel1.Controls.Add(this.pnlbat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_patient);
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
            // 
            // btn_medicament
            // 
            this.btn_medicament.FlatAppearance.BorderSize = 0;
            this.btn_medicament.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_medicament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_medicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicament.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_medicament.ForeColor = System.Drawing.Color.White;
            this.btn_medicament.Location = new System.Drawing.Point(15, 639);
            this.btn_medicament.Name = "btn_medicament";
            this.btn_medicament.Size = new System.Drawing.Size(178, 57);
            this.btn_medicament.TabIndex = 7;
            this.btn_medicament.Text = "Medicament";
            this.btn_medicament.UseVisualStyleBackColor = true;
            this.btn_medicament.Click += new System.EventHandler(this.btn_medicament_Click);
            // 
            // btn_rendezvous
            // 
            this.btn_rendezvous.FlatAppearance.BorderSize = 0;
            this.btn_rendezvous.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_rendezvous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_rendezvous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rendezvous.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_rendezvous.ForeColor = System.Drawing.Color.White;
            this.btn_rendezvous.Location = new System.Drawing.Point(15, 576);
            this.btn_rendezvous.Name = "btn_rendezvous";
            this.btn_rendezvous.Size = new System.Drawing.Size(178, 57);
            this.btn_rendezvous.TabIndex = 6;
            this.btn_rendezvous.Text = "Rendez Vous";
            this.btn_rendezvous.UseVisualStyleBackColor = true;
            this.btn_rendezvous.Click += new System.EventHandler(this.btn_rendezvous_Click);
            // 
            // btn_antecedent
            // 
            this.btn_antecedent.FlatAppearance.BorderSize = 0;
            this.btn_antecedent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_antecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_antecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_antecedent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_antecedent.ForeColor = System.Drawing.Color.White;
            this.btn_antecedent.Location = new System.Drawing.Point(15, 422);
            this.btn_antecedent.Name = "btn_antecedent";
            this.btn_antecedent.Size = new System.Drawing.Size(178, 57);
            this.btn_antecedent.TabIndex = 5;
            this.btn_antecedent.Text = "Antecedent Medicale";
            this.btn_antecedent.UseVisualStyleBackColor = true;
            this.btn_antecedent.Click += new System.EventHandler(this.btn_antecedent_Click);
            // 
            // btn_prescription
            // 
            this.btn_prescription.FlatAppearance.BorderSize = 0;
            this.btn_prescription.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_prescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_prescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_prescription.ForeColor = System.Drawing.Color.White;
            this.btn_prescription.Location = new System.Drawing.Point(15, 498);
            this.btn_prescription.Name = "btn_prescription";
            this.btn_prescription.Size = new System.Drawing.Size(178, 57);
            this.btn_prescription.TabIndex = 4;
            this.btn_prescription.Text = "Prescription";
            this.btn_prescription.UseVisualStyleBackColor = true;
            this.btn_prescription.Click += new System.EventHandler(this.btn_prescription_Click);
            // 
            // btn_analyse
            // 
            this.btn_analyse.FlatAppearance.BorderSize = 0;
            this.btn_analyse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_analyse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_analyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analyse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_analyse.ForeColor = System.Drawing.Color.White;
            this.btn_analyse.Location = new System.Drawing.Point(15, 338);
            this.btn_analyse.Name = "btn_analyse";
            this.btn_analyse.Size = new System.Drawing.Size(178, 57);
            this.btn_analyse.TabIndex = 3;
            this.btn_analyse.Text = "Analyse Medicale";
            this.btn_analyse.UseVisualStyleBackColor = true;
            this.btn_analyse.Click += new System.EventHandler(this.btn_analyse_Click);
            // 
            // btn_medecin
            // 
            this.btn_medecin.FlatAppearance.BorderSize = 0;
            this.btn_medecin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_medecin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_medecin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medecin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_medecin.ForeColor = System.Drawing.Color.White;
            this.btn_medecin.Location = new System.Drawing.Point(15, 255);
            this.btn_medecin.Name = "btn_medecin";
            this.btn_medecin.Size = new System.Drawing.Size(178, 57);
            this.btn_medecin.TabIndex = 2;
            this.btn_medecin.Text = "Medecin";
            this.btn_medecin.UseVisualStyleBackColor = true;
            this.btn_medecin.Click += new System.EventHandler(this.btn_medecin_Click);
            // 
            // pnlbat
            // 
            this.pnlbat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlbat.Location = new System.Drawing.Point(3, 176);
            this.pnlbat.Name = "pnlbat";
            this.pnlbat.Size = new System.Drawing.Size(11, 57);
            this.pnlbat.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_patient
            // 
            this.btn_patient.FlatAppearance.BorderSize = 0;
            this.btn_patient.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_patient.ForeColor = System.Drawing.Color.White;
            this.btn_patient.Location = new System.Drawing.Point(15, 176);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(178, 57);
            this.btn_patient.TabIndex = 0;
            this.btn_patient.Text = "Patient";
            this.btn_patient.UseVisualStyleBackColor = true;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.button3.Image = global::ProjetSuiviePatient.Properties.Resources.icons8_minimize_window_32;
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
            this.button2.Image = global::ProjetSuiviePatient.Properties.Resources.icons8_close_window_32;
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
            this.main.BackgroundImage = global::ProjetSuiviePatient.Properties.Resources._23;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_patient;
        private Panel main;
        private Button button2;
        private Button button3;
        private Button btn_antecedent;
        private Button btn_prescription;
        private Button btn_analyse;
        private Button btn_medecin;
        private Panel pnlbat;
        private Button btn_rendezvous;
        private Button btn_medicament;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button btn_deconnec;
        private PictureBox pictureBox1;
    }
}