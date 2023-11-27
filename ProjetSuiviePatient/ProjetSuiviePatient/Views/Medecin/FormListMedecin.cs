using ProjetSuiviePatient.Controllers;
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

namespace ProjetSuiviePatient.Views.Medecin
{
    public partial class FormListMedecin : UserControl
    {
        private static FormListMedecin formList;

        MedecinControllers medecinControllers;

        string defaultInput = "Search...";

        public static FormListMedecin Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListMedecin();
                }
                return formList;
            }
        }
        public FormListMedecin()
        {
            InitializeComponent();
        }
    }
}
