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
    public class FournisseurService
    {
        FournisseurDAO fournisseurDAO;

        public FournisseurService()
        {
            fournisseurDAO = new FournisseurDAO();
        }

        public Fournisseur Save(Fournisseur fournisseur)
        {
            try
            {
                if (!Exists(fournisseur.NomFournisseur))
                    return fournisseurDAO.Save(fournisseur);
                else
                {
                    MessageBox.Show
                        (
                            $"Le fournisseur '{fournisseur.NomFournisseur} existe déjà !",
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
            return fournisseurDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<Fournisseur> fournisseurs = FindAll();
                List<Fournisseur> foundFournisseurs = fournisseurs.FindAll
                    (
                        fournisseur => fournisseur.NomFournisseur == name
                    );

                return foundFournisseurs.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Fournisseur> FindAll()
        {
            return fournisseurDAO.FindAll();
        }

        public Fournisseur FindByName(string name)
        {
            List<Fournisseur> patients = FindAll();
            return patients.Find(patient => patient.NomFournisseur == name);
        }

        public Fournisseur FindById(int id)
        {
            try
            {
                return FindAll().Find(patient => patient.FournisseurID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Fournisseur> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    patient => patient.NomFournisseur.IndexOf
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

        public Fournisseur Update(Fournisseur patient)
        {
            try
            {
                bool hasThisIdHere = Exists(patient.FournisseurID);
                bool hasThisNameHere = Exists(patient.NomFournisseur);
                if (hasThisIdHere && !hasThisNameHere)
                    return fournisseurDAO.Update(patient);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce fournisseur n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                else if (hasThisNameHere)
                {
                    MessageBox.Show
                        (
                            $"Le fournisseur '{patient.NomFournisseur}' existe déjà !",
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
                    return fournisseurDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce fournisseur n'existe pas !",
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
    }
}
