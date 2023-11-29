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
    public class ProduitService
    {
        ProduitDAO produitDAO;

        public ProduitService()
        {
            produitDAO = new ProduitDAO();
        }

        public Produit Save(Produit produit)
        {
            try
            {
                if (!Exists(produit.NomProduit))
                    return produitDAO.Save(produit);
                else
                {
                    MessageBox.Show
                        (
                            $"Le produit '{produit.NomProduit} existe déjà !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return produitDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<Produit> produits = FindAll();
                List<Produit> foundProduits = produits.FindAll
                    (
                        produit => produit.NomProduit == name
                    );

                return foundProduits.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Produit> FindAll()
        {
            return produitDAO.FindAll();
        }

        public Produit FindById(int id)
        {
            try
            {
                return FindAll().Find(produit => produit.ProduitID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Produit Update(Produit produit)
        {
            try
            {
                bool hasThisIdHere = Exists(produit.ProduitID);
                bool hasThisNameHere = Exists(produit.NomProduit);
                if (hasThisIdHere && !hasThisNameHere)
                    return produitDAO.Update(produit);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce produit n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                else if (hasThisNameHere)
                {
                    MessageBox.Show
                        (
                            $"Le produit '{produit.NomProduit}' existe déjà !",
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
                    return produitDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce produit n'existe pas !",
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

        public Produit FindByName(string name)
        {
            List<Produit> produits = FindAll();
            return produits.Find(produit => produit.NomProduit == name);
        }

        public List<Produit> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    produit => produit.NomProduit.IndexOf
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
