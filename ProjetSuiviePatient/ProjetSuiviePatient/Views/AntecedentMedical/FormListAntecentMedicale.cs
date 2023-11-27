using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.AnalyseMedicale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.AntecedentMedical
{
    public partial class FormListAntecedentMedicale : UserControl
    {
        private static FormListAntecedentMedicale formList;

        AntecedentMedicaleControllers antecedentMedicaleControllers;

        string defaultInput = "Search...";

        public static FormListAntecedentMedicale Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListAntecedentMedicale();
                }
                return formList;
            }
        }
        public FormListAntecedentMedicale()
        {
            InitializeComponent();
        }
    }
}
