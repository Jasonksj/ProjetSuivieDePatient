using ProjetSuiviePatient.DAO;
using ProjetSuiviePatient.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSuiviePatient.Services
{
    public class MedecinService
    {
        MedecinDAO medecinDAO;

        public MedecinService()
        {
            medecinDAO = new MedecinDAO();
        }

        public Medecin Save(Medecin medecin)
        {
            try
            {
                if (!Exists(medecin.Nom))
                    return medecinDAO.Save(medecin);
                else
                {
                    MessageBox.Show
                        (
                            $"Le medecin '{medecin.Nom} existe déjà !",
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
            return medecinDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<Medecin> medecins = FindAll();
                List<Medecin> foundMedecins = medecins.FindAll
                    (
                        medecin => medecin.Nom == name
                    );

                return foundMedecins.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Medecin> FindAll()
        {
            return medecinDAO.FindAll();
        }

        public Medecin FindByName(string name)
        {
            List<Medecin> medecins = FindAll();
            return medecins.Find(medecin => medecin.Nom == name);
        }

        public Medecin FindById(int id)
        {
            try
            {
                return FindAll().Find(medecin => medecin.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Medecin> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    medecin => medecin.Nom.IndexOf
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

        public Medecin Update(Medecin medecin)
        {
            try
            {
                bool hasThisIdHere = Exists(medecin.ID);
                bool hasThisNameHere = Exists(medecin.Nom);
                if (hasThisIdHere && !hasThisNameHere)
                    return medecinDAO.Update(medecin);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce medecin n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                else if (hasThisNameHere)
                {
                    MessageBox.Show
                        (
                            $"Le medecin '{medecin.Nom}' existe déjà !",
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
                    return medecinDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce medecin n'existe pas !",
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
