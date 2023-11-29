using Projet_Marche.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.Views.User
{
    public partial class FormRegister : Form
    {
        UserControllers userControllers;
        public FormRegister()
        {
            InitializeComponent();
            userControllers = new UserControllers();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Entities.Utilisateur userCreated = userControllers.Save(Username_txt.Text, password_txt.Text);
            if (userCreated != null)
            {
                MessageBox.Show
                   (
                       $"Création de l'utilisateur '{userCreated.Nom}' éffectuée avec succès !",
                       "Succès",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                   );
                Close();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin formRegister = new FormLogin();
            formRegister.Show();
        }
    }
}
