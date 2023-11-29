using Projet_Marche.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.DAO
{
    public class ClientDAO
    {
        MarchesEntities marchesEntities;
        Client client;

        public ClientDAO()
        {
            marchesEntities = new MarchesEntities();
            client = new Client();
        }

        public Client Save(Client client)
        {
            try
            {
                this.client = client;
                marchesEntities.Clients.Add(this.client);
                marchesEntities.SaveChanges();
                return this.client;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Enregistrement impossible du client '{this.client.NomClient}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }

        public List<Client> FindAll()
        {
            try
            {
                return marchesEntities.Clients.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public int Delete(int id)
        {
            try
            {
                client = marchesEntities.Clients.FirstOrDefault
                    (
                        client => client.ClientID == id
                    );
                marchesEntities.Clients.Remove(client);
                marchesEntities.SaveChanges();
                return client.ClientID;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Suppression impossible du client '{this.client.NomClient}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return -1;
            }
        }

        public bool Exists(int id)
        {
            try
            {
                return marchesEntities.Clients.SingleOrDefault(client => client.ClientID == id) != null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur : {ex.Message}");
            }
        }

        public Client Update(Client client)
        {
            try
            {
                this.client = client;
                marchesEntities.Clients.AddOrUpdate(this.client);
                marchesEntities.SaveChanges();
                return this.client;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"Modification impossible du client  '{this.client.NomClient}'!\nErreur : {ex.Message}",
                        "Echec",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return null;
            }
        }
    }
}
