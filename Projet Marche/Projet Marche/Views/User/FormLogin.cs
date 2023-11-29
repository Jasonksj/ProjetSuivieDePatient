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
    public partial class FormLogin : Form
    {
        UserControllers userControllers;
        public FormLogin()
        {
            InitializeComponent();
            userControllers = new UserControllers();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = Username_txt.Text;
            string password = password_txt.Text;
            if(userControllers.Exists(username, password))
            {
                this.Close();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}
