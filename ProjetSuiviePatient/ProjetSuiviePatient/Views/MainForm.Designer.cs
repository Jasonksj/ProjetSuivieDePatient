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
            this.btn_conges = new System.Windows.Forms.Button();
            this.btn_absence = new System.Windows.Forms.Button();
            this.btn_paiement = new System.Windows.Forms.Button();
            this.btn_contrat = new System.Windows.Forms.Button();
            this.btn_fonction = new System.Windows.Forms.Button();
            this.btn_dept = new System.Windows.Forms.Button();
            this.pnlbat = new System.Windows.Forms.Panel();
            this.btn_employee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.main.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_deconnec);
            this.panel1.Controls.Add(this.btn_conges);
            this.panel1.Controls.Add(this.btn_absence);
            this.panel1.Controls.Add(this.btn_paiement);
            this.panel1.Controls.Add(this.btn_contrat);
            this.panel1.Controls.Add(this.btn_fonction);
            this.panel1.Controls.Add(this.btn_dept);
            this.panel1.Controls.Add(this.pnlbat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_employee);
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
            this.btn_deconnec.Location = new System.Drawing.Point(15, 773);
            this.btn_deconnec.Name = "btn_deconnec";
            this.btn_deconnec.Size = new System.Drawing.Size(139, 57);
            this.btn_deconnec.TabIndex = 9;
            this.btn_deconnec.Text = "Deconnexion";
            this.btn_deconnec.UseVisualStyleBackColor = true;
            // 
            // btn_conges
            // 
            this.btn_conges.FlatAppearance.BorderSize = 0;
            this.btn_conges.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_conges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_conges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conges.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_conges.ForeColor = System.Drawing.Color.White;
            this.btn_conges.Location = new System.Drawing.Point(15, 639);
            this.btn_conges.Name = "btn_conges";
            this.btn_conges.Size = new System.Drawing.Size(178, 57);
            this.btn_conges.TabIndex = 7;
            this.btn_conges.Text = "Medicament";
            this.btn_conges.UseVisualStyleBackColor = true;
            // 
            // btn_absence
            // 
            this.btn_absence.FlatAppearance.BorderSize = 0;
            this.btn_absence.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_absence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_absence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_absence.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_absence.ForeColor = System.Drawing.Color.White;
            this.btn_absence.Location = new System.Drawing.Point(15, 576);
            this.btn_absence.Name = "btn_absence";
            this.btn_absence.Size = new System.Drawing.Size(178, 57);
            this.btn_absence.TabIndex = 6;
            this.btn_absence.Text = "Rendez Vous";
            this.btn_absence.UseVisualStyleBackColor = true;
            // 
            // btn_paiement
            // 
            this.btn_paiement.FlatAppearance.BorderSize = 0;
            this.btn_paiement.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_paiement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_paiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paiement.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_paiement.ForeColor = System.Drawing.Color.White;
            this.btn_paiement.Location = new System.Drawing.Point(15, 422);
            this.btn_paiement.Name = "btn_paiement";
            this.btn_paiement.Size = new System.Drawing.Size(178, 57);
            this.btn_paiement.TabIndex = 5;
            this.btn_paiement.Text = "Antecedent Medicale";
            this.btn_paiement.UseVisualStyleBackColor = true;
            // 
            // btn_contrat
            // 
            this.btn_contrat.FlatAppearance.BorderSize = 0;
            this.btn_contrat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_contrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_contrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contrat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_contrat.ForeColor = System.Drawing.Color.White;
            this.btn_contrat.Location = new System.Drawing.Point(15, 498);
            this.btn_contrat.Name = "btn_contrat";
            this.btn_contrat.Size = new System.Drawing.Size(178, 57);
            this.btn_contrat.TabIndex = 4;
            this.btn_contrat.Text = "Prescription";
            this.btn_contrat.UseVisualStyleBackColor = true;
            // 
            // btn_fonction
            // 
            this.btn_fonction.FlatAppearance.BorderSize = 0;
            this.btn_fonction.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_fonction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fonction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fonction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_fonction.ForeColor = System.Drawing.Color.White;
            this.btn_fonction.Location = new System.Drawing.Point(15, 338);
            this.btn_fonction.Name = "btn_fonction";
            this.btn_fonction.Size = new System.Drawing.Size(178, 57);
            this.btn_fonction.TabIndex = 3;
            this.btn_fonction.Text = "Analyse Medicale";
            this.btn_fonction.UseVisualStyleBackColor = true;
            // 
            // btn_dept
            // 
            this.btn_dept.FlatAppearance.BorderSize = 0;
            this.btn_dept.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_dept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_dept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dept.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_dept.ForeColor = System.Drawing.Color.White;
            this.btn_dept.Location = new System.Drawing.Point(15, 255);
            this.btn_dept.Name = "btn_dept";
            this.btn_dept.Size = new System.Drawing.Size(178, 57);
            this.btn_dept.TabIndex = 2;
            this.btn_dept.Text = "Medecin";
            this.btn_dept.UseVisualStyleBackColor = true;
            // 
            // pnlbat
            // 
            this.pnlbat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlbat.Location = new System.Drawing.Point(3, 176);
            this.pnlbat.Name = "pnlbat";
            this.pnlbat.Size = new System.Drawing.Size(11, 57);
            this.pnlbat.TabIndex = 1;
            // 
            // btn_employee
            // 
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(15, 176);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(178, 57);
            this.btn_employee.TabIndex = 0;
            this.btn_employee.Text = "Patient";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
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
            this.main.Controls.Add(this.pictureBox2);
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1261, 823);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel2.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_employee;
        private Panel main;
        private Button button2;
        private Button button3;
        private Button btn_paiement;
        private Button btn_contrat;
        private Button btn_fonction;
        private Button btn_dept;
        private Panel pnlbat;
        private Button btn_absence;
        private Button btn_conges;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Button btn_deconnec;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}