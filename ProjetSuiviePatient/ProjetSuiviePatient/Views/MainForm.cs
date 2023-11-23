using ProjetSuiviePatient.Views.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            pnlbat.Top = btn_employee.Top;
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Souhaitez-vous vraiment quitter ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
