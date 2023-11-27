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
    public class AntecedentMedicaleService
    {
        AntecedentMedicaleDAO antecedentMedicaleDAO;

        public AntecedentMedicaleService()
        {
            antecedentMedicaleDAO = new AntecedentMedicaleDAO();
        }

        public Antecedentmedical Save(Antecedentmedical antecedentmedical)
        {
            try
            {
                return antecedentMedicaleDAO.Save(antecedentmedical);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return antecedentMedicaleDAO.Exists(id);
        }

        public List<Antecedentmedical> FindAll()
        {
            return antecedentMedicaleDAO.FindAll();
        }

        public Antecedentmedical FindById(int id)
        {
            try
            {
                return FindAll().Find(antecedentMedicale => antecedentMedicale.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Antecedentmedical Update(Antecedentmedical antecedentMedicale)
        {
            try
            {
                bool hasThisIdHere = Exists(antecedentMedicale.ID);
                if (hasThisIdHere)
                    return antecedentMedicaleDAO.Update(antecedentMedicale);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Cette antecedent medical n'existe pas !",
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
                    return antecedentMedicaleDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Cette antecedent medicale n'existe pas !",
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

        public int PatientID()
        {
            return antecedentMedicaleDAO.PatientID();
        }
    }
}
