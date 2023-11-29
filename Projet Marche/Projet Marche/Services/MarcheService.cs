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
    public class MarcheService
    {
        MarcheDAO marcheDAO;

        public MarcheService()
        {
            marcheDAO = new MarcheDAO();
        }

        public March Save(March marche)
        {
            try
            {
                if (!Exists(marche.NomMarche))
                    return marcheDAO.Save(marche);
                else
                {
                    MessageBox.Show
                        (
                            $"Le marché '{marche.NomMarche} existe déjà !",
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
            return marcheDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<March> marches = FindAll();
                List<March> foundMarches = marches.FindAll
                    (
                        marche => marche.NomMarche == name
                    );

                return foundMarches.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<March> FindAll()
        {
            return marcheDAO.FindAll();
        }

        public March FindById(int id)
        {
            try
            {
                return FindAll().Find(marche => marche.MarcheID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public March Update(March marche)
        {
            try
            {
                bool hasThisIdHere = Exists(marche.MarcheID);
                bool hasThisNameHere = Exists(marche.NomMarche);
                if (hasThisIdHere && !hasThisNameHere)
                    return marcheDAO.Update(marche);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce marche n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                else if (hasThisNameHere)
                {
                    MessageBox.Show
                        (
                            $"Le marche '{marche.NomMarche}' existe déjà !",
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
                    return marcheDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce marché n'existe pas !",
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

        public March FindByName(string name)
        {
            List<March> marches = FindAll();
            return marches.Find(marche => marche.NomMarche == name);
        }

        public List<March> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    marche => marche.NomMarche.IndexOf
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
