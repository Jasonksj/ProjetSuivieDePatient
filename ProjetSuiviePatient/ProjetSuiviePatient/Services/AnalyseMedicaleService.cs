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
    public class AnalyseMedicaleService
    {
        AnalyseMedicaleDAO analyseMedicaleDAO;

        public AnalyseMedicaleService()
        {
            analyseMedicaleDAO = new AnalyseMedicaleDAO();
        }

        public Analysemedicale Save(Analysemedicale analyseMedicale)
        {
            try
            {
                return analyseMedicaleDAO.Save(analyseMedicale);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return analyseMedicaleDAO.Exists(id);
        }

        public List<Analysemedicale> FindAll()
        {
            return analyseMedicaleDAO.FindAll();
        }

        public Analysemedicale FindById(int id)
        {
            try
            {
                return FindAll().Find(analyseMedicale => analyseMedicale.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Analysemedicale Update(Analysemedicale analyseMedicale)
        {
            try
            {
                bool hasThisIdHere = Exists(analyseMedicale.ID);
                if (hasThisIdHere)
                    return analyseMedicaleDAO.Update(analyseMedicale);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Cette analyse medicale n'existe pas !",
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
                    return analyseMedicaleDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Cette analyse medicale n'existe pas !",
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

        public int MedecinID()
        {
            return analyseMedicaleDAO.MedecinID();
        }

        public int PatientID()
        {
            return analyseMedicaleDAO.PatientID();
        }

    }
}
