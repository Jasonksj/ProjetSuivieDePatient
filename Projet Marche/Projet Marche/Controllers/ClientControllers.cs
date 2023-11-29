using Projet_Marche.DAO;
using Projet_Marche.Entities;
using Projet_Marche.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Marche.Controllers
{
    public class ClientControllers
    {
        ClientService clientService;

        public ClientControllers()
        {
            clientService = new ClientService();
        }

        public Client Save(string NomClient, string AdresseClient, string EmailClient)
        {
            Client client = new Client
            {
                NomClient = NomClient,
                AdresseClient = AdresseClient,
                EmailClient = EmailClient
            };
            return clientService.Save(client);
        }

        public List<Client> FindAll()
        {
            return clientService.FindAll();
        }

        public Client Update(Client client)
        {
            return clientService.Update(client);
        }

        public int Delete(int id)
        {
            return clientService.Delete(id);
        }

        public bool Exists(int id)
        {
            return clientService.Exists(id);
        }

        public Client FindById(int id)
        {
            return clientService.FindById(id);
        }

        public Client FindByName(string name)
        {
            return clientService.FindByName(name);
        }

        public List<Client> FilterByName(string name)
        {
            return clientService.FilterByName(name);
        }
    }
}
