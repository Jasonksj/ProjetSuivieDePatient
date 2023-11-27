using ProjetSuiviePatient.Controllers;
using ProjetSuiviePatient.Views.Medicament;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Views.RendezVous
{
    public partial class FormListRendezVous : UserControl
    {
        private static FormListRendezVous formList;

        RendezVousControllers rendezVousControllers;

        string defaultInput = "Search...";

        public static FormListRendezVous Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListRendezVous();
                }
                return formList;
            }
        }
        public FormListRendezVous()
        {
            InitializeComponent();
        }
    }
}
