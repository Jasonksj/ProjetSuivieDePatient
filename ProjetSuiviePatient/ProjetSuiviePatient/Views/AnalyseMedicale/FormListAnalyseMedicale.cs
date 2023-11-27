using ProjetSuiviePatient.Controllers;
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

namespace ProjetSuiviePatient.Views.AnalyseMedicale
{
    public partial class FormListAnalyseMedicale : UserControl
    {
        private static FormListAnalyseMedicale formList;

        AnalyseMedicaleControllers analyseMedicaleControllers;

        string defaultInput = "Search...";

        public static FormListAnalyseMedicale Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListAnalyseMedicale();
                }
                return formList;
            }
        }
        public FormListAnalyseMedicale()
        {
            InitializeComponent();
        }
    }
}
