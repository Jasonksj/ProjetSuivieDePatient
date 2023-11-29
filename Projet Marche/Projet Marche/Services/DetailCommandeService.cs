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
    public class DetailCommandeService
    {
        DetailCommandeDAO detailCommandeDAO;

        public DetailCommandeService()
        {
            detailCommandeDAO = new DetailCommandeDAO();
        }

        public DetailsCommande Save(DetailsCommande detailsCommande)
        {
            try
            {
                return detailCommandeDAO.Save(detailsCommande);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return detailCommandeDAO.Exists(id);
        }

        public List<DetailsCommande> FindAll()
        {
            return detailCommandeDAO.FindAll();
        }

        public DetailsCommande FindById(int id)
        {
            try
            {
                return FindAll().Find(detailsCommande => detailsCommande.DetailID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public DetailsCommande Update(DetailsCommande detailsCommande)
        {
            try
            {
                bool hasThisIdHere = Exists(detailsCommande.DetailID);
                if (hasThisIdHere)
                    return detailCommandeDAO.Update(detailsCommande);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce detail n'existe pas !",
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
                    return detailCommandeDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce detail n'existe pas !",
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

        public DetailsCommande FindByName(string name)
        {
            List<DetailsCommande> detailsCommandes = FindAll();
            return detailsCommandes.Find(client => client.MontantTotal == Decimal.Parse(name));
        }

        public List<DetailsCommande> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    client => client.MontantTotal.ToString().IndexOf
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
