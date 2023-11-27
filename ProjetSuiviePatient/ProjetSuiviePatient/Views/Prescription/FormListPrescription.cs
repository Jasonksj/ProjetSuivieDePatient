﻿using ProjetSuiviePatient.Controllers;
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

namespace ProjetSuiviePatient.Views.Prescription
{
    public partial class FormListPrescription : UserControl
    {
        private static FormListPrescription formList;

        PrescriptionControllers prescriptionControllers;

        string defaultInput = "Search...";

        public static FormListPrescription Instance
        {
            get
            {
                if (formList == null)
                {
                    formList = new FormListPrescription();
                }
                return formList;
            }
        }
        public FormListPrescription()
        {
            InitializeComponent();
        }
    }
}
