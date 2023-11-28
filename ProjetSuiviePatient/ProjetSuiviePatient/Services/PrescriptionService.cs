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
    public class PrescriptionService
    {
        PrescriptionDAO prescriptionDAO;

        public PrescriptionService()
        {
            prescriptionDAO = new PrescriptionDAO();
        }

        public Prescription Save(Prescription prescription)
        {
            try
            {
                return prescriptionDAO.Save(prescription);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return prescriptionDAO.Exists(id);
        }

        public List<Prescription> FindAll()
        {
            return prescriptionDAO.FindAll();
        }

        public Prescription FindById(int id)
        {
            try
            {
                return FindAll().Find(prescription => prescription.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Prescription Update(Prescription prescription)
        {
            try
            {
                bool hasThisIdHere = Exists(prescription.ID);
                if (hasThisIdHere)
                    return prescriptionDAO.Update(prescription);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Cette prescription n'existe pas !",
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
                    return prescriptionDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Cette prescription n'existe pas !",
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

        public Prescription FindByName(string name)
        {
            List<Prescription> prescriptions = FindAll();
            return prescriptions.Find(prescription => prescription.PosologieGenerale == name);
        }

        public List<Prescription> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    prescription => prescription.PosologieGenerale.IndexOf
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
