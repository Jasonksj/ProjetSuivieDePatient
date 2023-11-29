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
    public class CommandeService
    {
        CommandeDAO commandeDAO;

        public CommandeService()
        {
            commandeDAO = new CommandeDAO();
        }

        public Commande Save(Commande commande)
        {
            try
            {
                return commandeDAO.Save(commande);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return commandeDAO.Exists(id);
        }

        public List<Commande> FindAll()
        {
            return commandeDAO.FindAll();
        }

        public Commande FindByName(DateTime name)
        {
            List<Commande> commandes = FindAll();
            return commandes.Find(commande => commande.DateCommande == name);
        }

        public Commande FindById(int id)
        {
            try
            {
                return FindAll().Find(commande => commande.CommandeID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Commande Update(Commande commande)
        {
            try
            {
                bool hasThisIdHere = Exists(commande.CommandeID);
                if (hasThisIdHere)
                    return commandeDAO.Update(commande);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Cette commande n'existe pas !",
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
                    return commandeDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Cette commende n'existe pas !",
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

        public Commande FindByName(string name)
        {
            List<Commande> commandes = FindAll();
            return commandes.Find(client => client.DateCommande == DateTime.Parse(name));
        }

        public List<Commande> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    client => client.DateCommande.ToString().IndexOf
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
