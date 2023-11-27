using ProjetSuiviePatient.Views.Medicament;
using ProjetSuiviePatient.Views.Patient;
using ProjetSuiviePatient.Views.Prescription;
using ProjetSuiviePatient.Views.RendezVous;
using ProjetSuiviePatient.Views.AntecedentMedical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSuiviePatient.Views.AnalyseMedicale;
using ProjetSuiviePatient.Views.Medecin;

namespace ProjetSuiviePatient.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Souhaitez-vous vraiment quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_medecin_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_medecin.Top;
            if (!main.Controls.Contains(FormListMedecin.Instance))
            {
                main.Controls.Add(FormListMedecin.Instance);
                FormListMedecin.Instance.Dock = DockStyle.Fill;
                FormListMedecin.Instance.BringToFront();
            }
            else
            {
                FormListMedecin.Instance.BringToFront();
            }
        }

        private void btn_analyse_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_analyse.Top;
            if (!main.Controls.Contains(FormListAnalyseMedicale.Instance))
            {
                main.Controls.Add(FormListAnalyseMedicale.Instance);
                FormListAnalyseMedicale.Instance.Dock = DockStyle.Fill;
                FormListAnalyseMedicale.Instance.BringToFront();
            }
            else
            {
                FormListAnalyseMedicale.Instance.BringToFront();
            }
        }

        private void btn_antecedent_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_antecedent.Top;
            if (!main.Controls.Contains(FormListAntecedentMedicale.Instance))
            {
                main.Controls.Add(FormListAntecedentMedicale.Instance);
                FormListAntecedentMedicale.Instance.Dock = DockStyle.Fill;
                FormListAntecedentMedicale.Instance.BringToFront();
            }
            else
            {
                FormListAntecedentMedicale.Instance.BringToFront();
            }
        }

        private void btn_prescription_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_prescription.Top;
            if (!main.Controls.Contains(FormListPrescription.Instance))
            {
                main.Controls.Add(FormListPrescription.Instance);
                FormListPrescription.Instance.Dock = DockStyle.Fill;
                FormListPrescription.Instance.BringToFront();
            }
            else
            {
                FormListPrescription.Instance.BringToFront();
            }
        }

        private void btn_rendezvous_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_rendezvous.Top;
            if (!main.Controls.Contains(FormListRendezVous.Instance))
            {
                main.Controls.Add(FormListRendezVous.Instance);
                FormListRendezVous.Instance.Dock = DockStyle.Fill;
                FormListRendezVous.Instance.BringToFront();
            }
            else
            {
                FormListRendezVous.Instance.BringToFront();
            }
        }

        private void btn_medicament_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_medicament.Top;
            if (!main.Controls.Contains(FormListMedicament.Instance))
            {
                main.Controls.Add(FormListMedicament.Instance);
                FormListMedicament.Instance.Dock = DockStyle.Fill;
                FormListMedicament.Instance.BringToFront();
            }
            else
            {
                FormListMedicament.Instance.BringToFront();
            }
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_patient.Top;
            if (!main.Controls.Contains(FormListPatient.Instance))
            {
                main.Controls.Add(FormListPatient.Instance);
                FormListPatient.Instance.Dock = DockStyle.Fill;
                FormListPatient.Instance.BringToFront();
            }
            else
            {
                FormListPatient.Instance.BringToFront();
            }
        }
    }
}
