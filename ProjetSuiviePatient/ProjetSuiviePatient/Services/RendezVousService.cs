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
    public class RendezVousService
    {
        RendezVousDAO rendezVousDAO;

        public RendezVousService()
        {
            rendezVousDAO = new RendezVousDAO();
        }

        public Rendezvou Save(Rendezvou rendezvous)
        {
            try
            {
                return rendezVousDAO.Save(rendezvous);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public bool Exists(int id)
        {
            return rendezVousDAO.Exists(id);
        }

        public List<Rendezvou> FindAll()
        {
            return rendezVousDAO.FindAll();
        }

        public Rendezvou FindById(int id)
        {
            try
            {
                return FindAll().Find(rendezvous => rendezvous.ID == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur : " + ex.Message);
            }
        }

        public Rendezvou Update(Rendezvou rendezvous)
        {
            try
            {
                bool hasThisIdHere = Exists(rendezvous.ID);
                if (hasThisIdHere)
                    return rendezVousDAO.Update(rendezvous);
                else if (!hasThisIdHere)
                {
                    MessageBox.Show
                        (
                            $"Ce rendez-vous n'existe pas !",
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
                    return rendezVousDAO.Delete(id);
                else
                {
                    MessageBox.Show
                        (
                            $"Ce rendez-vous n'existe pas !",
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

        public Rendezvou FindByName(string name)
        {
            List<Rendezvou> rendezvous = FindAll();
            return rendezvous.Find(rendezvou => rendezvou.Motif == name);
        }

        public List<Rendezvou> FilterByName(string name)
        {
            try
            {
                return FindAll().Where
                (
                    rendezvou => rendezvou.Motif.IndexOf
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
