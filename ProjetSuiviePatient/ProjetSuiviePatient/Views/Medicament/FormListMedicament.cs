using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.Medecin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.Medicament
{
    public partial class FormListMedicament : UserControl
    {
        private static FormListMedicament formList;

        MedicamentControllers medicamentControllers;

        string defaultInput = "Search...";

        public static FormListMedicament Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListMedicament();
                }
                return formList;
            }
        }
        public FormListMedicament()
        {
            InitializeComponent();
        }
    }
}
