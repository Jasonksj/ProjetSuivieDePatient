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

namespace Projet_Marche.Views.Client
{
    public partial class FormClient : Form
    {
        bool isUpdateForm;

        ClientControllers clientControllers;
        Entities.Client client;
        public FormClient()
        {
            InitializeComponent();
            isUpdateForm = false;
            clientControllers = new ClientControllers();
        }

        public FormClient(Entities.Client client)
        {
            InitializeComponent();
            this.client = client;
            isUpdateForm = true;
            clientControllers = new ClientControllers();
        }

        private void LoadForm()
        {
            if (!isUpdateForm)
                titre.Text = "AJOUT D'UN CLIENT";
            else
            {
                titre.Text = "MODIFICATION D'UN CLIENT";
                btn_valider.Text = "Modifier";
                txt_nom.Text = client.NomClient;
                txt_adresse.Text = client.AdresseClient;
                txt_email.Text = client.EmailClient;
                txt_nom.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateForm)
                {
                    client.NomClient = txt_nom.Text;
                    client.AdresseClient = txt_adresse.Text;
                    client.EmailClient = txt_email.Text;
                    Entities.Client clientUpdated = clientControllers.Update
                        (client);
                    if (clientUpdated != null)
                    {
                        MessageBox.Show
                            (
                                "Modification éffectuée avec succès !",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        Close();
                    }
                }
                else
                {
                    Entities.Client clientCreated = clientControllers.Save
                    (txt_nom.Text, txt_adresse.Text, txt_email.Text);
                    if (clientCreated != null)
                    {
                        MessageBox.Show
                           (
                               $"Création du client '{clientCreated.NomClient}' éffectuée avec succès !",
                               "Succès",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information
                           );
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
