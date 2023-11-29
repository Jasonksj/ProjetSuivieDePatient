using Projet_Marche.DAO;
using Projet_Marche.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Marche.Services
{
    public class ClientService
    {
        ClientDAO clientDAO;

        public ClientService()
        {
            clientDAO = new ClientDAO();
        }

        public Client Save(Client client)
        {
            try
            {
                return clientDAO.Save(client);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return clientDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<Client> clients = FindAll();
                List<Client> foundClientss = clients.FindAll
                    (
                        client => client.NomClient == name
                    );

                return foundClientss.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Client> FindAll()
        {
            return clientDAO.FindAll();
        }

        public Client FindById(int id)
        {
            try
            {
                return FindAll().Find(client => client.ClientID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Client Update(Client client)
        {
            try
            {
                bool hasThisIdHere = Exists(client.ClientID);
                if (hasThisIdHere)
                    return clientDAO.Update(client);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce client n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                if (Exists(id))
                    return clientDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce client n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        } 

        public Client FindByName(string name)
        {
            List<Client> clients = FindAll();
            return clients.Find(client => client.NomClient == name);
        }

        public List<Client> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    client => client.NomClient.IndexOf
                    (
                        name,
                        StringComparison.CurrentCultureIgnoreCase
                    ) != -1
                ).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

    }
}
