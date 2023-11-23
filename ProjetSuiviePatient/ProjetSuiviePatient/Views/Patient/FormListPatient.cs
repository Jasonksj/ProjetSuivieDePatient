using ProjetSuiviePatient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Patient
{
    public partial class FormListPatient : UserControl
    {
        private static FormListPatient formList;

        PatientControllers patientControllers;

        string defaultInput = "Search...";

        public static FormListPatient Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListPatient();
                }
                return formList;
            }
        }
        public FormListPatient()
        {
            InitializeComponent();
            patientControllers = new PatientControllers();
        }

        private void LoadForm()
        {
            PopulateDataGridView(patientControllers.FindAll());
        }

        private void PopulateDataGridView(List<Entities.Patient> patients)
        {
            dataGridView1.Rows.Clear();

            patients.ForEach
                (
                    delegate (Entities.Patient patient)
                    {
                        dataGridView1.Rows.Add(false, patient.Nom, patient.Prenom, patient.DateNaissance, patient.Sexe,
                                                      patient.Adresse, patient.Telephone, patient.Email,  patient.DerniereVisite,
                                                      patient.GroupeSanguin, patient.NumeroAssuranceMaladie, patient.CommentairesMedicaux);
                    }
                );
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            FormPatient formPatient = new FormPatient();
            formPatient.ShowDialog();
        }

        private void FormListPatient_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
