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
    public class MedicamentService
    {
        MedicamentDAO medicamentDAO;

        public MedicamentService()
        {
            medicamentDAO = new MedicamentDAO();
        }

        public Medicament Save(Medicament medicament)
        {
            try
            {
                if (!Exists(medicament.NomMedicament))
                    return medicamentDAO.Save(medicament);
                else
                {
                    MessageBox.Show
                        (
                            $"Le medicament '{medicament.NomMedicament} existe déjà !",
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
            return medicamentDAO.Exists(id);
        }

        public bool Exists(string name)
        {
            try
            {
                List<Medicament> medicaments = FindAll();
                List<Medicament> foundMedicaments = medicaments.FindAll
                    (
                        medicament => medicament.NomMedicament == name
                    );

                return foundMedicaments.Count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Medicament> FindAll()
        {
            return medicamentDAO.FindAll();
        }

        public Medicament FindByName(string name)
        {
            List<Medicament> medicaments = FindAll();
            return medicaments.Find(medicament => medicament.NomMedicament == name);
        }

        public Medicament FindById(int id)
        {
            try
            {
                return FindAll().Find(medicament => medicament.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public List<Medicament> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    medicament => medicament.NomMedicament.IndexOf
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

        public Medicament Update(Medicament medicament)
        {
            try
            {
                bool hasThisIdHere = Exists(medicament.ID);
                bool hasThisNameHere = Exists(medicament.NomMedicament);
                if (hasThisIdHere && !hasThisNameHere)
                    return medicamentDAO.Update(medicament);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce medicament n'existe pas !",
                            "Echec",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                else if (hasThisNameHere)
                {
                    MessageBox.Show
                        (
                            $"Le medicament '{medicament.NomMedicament}' existe déjà !",
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
                    return medicamentDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce medicament n'existe pas !",
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
