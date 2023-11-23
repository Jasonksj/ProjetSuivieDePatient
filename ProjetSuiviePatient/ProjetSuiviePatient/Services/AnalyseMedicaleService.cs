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
        

        public AnalyseMedicaleService()
        {
            
        }

        //// CREATE
        //public AnalyseMedicale CreateAnalyseMedicale(AnalyseMedicale analyseMedicale)
        //{
        //    try
        //    {
        //        this.analyseMedicale = analyseMedicale;
        //        _context.AnalyseMedicales.Add(analyseMedicale);
        //        _context.SaveChanges();
        //        return this.analyseMedicale;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show
        //            (
        //                $"Enregistrement impossible de la demande !\nErreur : {ex.Message}",
        //                "Erreur",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error
        //            );
        //        return null;
        //    }
        //}

        //// READ
        //public List<AnalyseMedicale> FindAllAnalyseMedicales()
        //{
        //    try
        //    {
        //        return _context.AnalyseMedicales.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Erreur {ex.Message}");
        //    }
        //}

        //public AnalyseMedicale GetAnalyseMedicaleById(int analyseMedicaleId)
        //{
        //    try
        //    {
        //        return _context.AnalyseMedicales.Find(analyseMedicaleId);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Erreur {ex.Message}");
        //    }
        //}

        //// UPDATE
        //public void UpdateAnalyseMedicale(AnalyseMedicale updatedAnalyseMedicale)
        //{
        //    try
        //    {
        //        var existingAnalyseMedicale = _context.AnalyseMedicales.Find(updatedAnalyseMedicale.ID);

        //        if (existingAnalyseMedicale != null)
        //        {
        //            existingAnalyseMedicale.DateAnalyse = updatedAnalyseMedicale.DateAnalyse;
        //            existingAnalyseMedicale.TypeAnalyse = updatedAnalyseMedicale.TypeAnalyse;
        //            existingAnalyseMedicale.Resultats = updatedAnalyseMedicale.Resultats;
        //            existingAnalyseMedicale.Laboratoire = updatedAnalyseMedicale.Laboratoire;
        //            existingAnalyseMedicale.CommentairesResultats = updatedAnalyseMedicale.CommentairesResultats;
        //            _context.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Erreur {ex.Message}");
        //    }
        //}

        //// DELETE
        //public int DeleteAnalyseMedicale(int analyseMedicaletId)
        //{
        //    try
        //    {
        //        analyseMedicale = _context.AnalyseMedicales.FirstOrDefault
        //        (
        //            analyseMedicale => analyseMedicale.ID == analyseMedicaletId
        //        );
        //        _context.AnalyseMedicales.Remove(analyseMedicale);
        //        _context.SaveChanges();
        //        return analyseMedicale.ID;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show
        //        (
        //                $"Suppression du paiement de l'employé impossible !\nErreur : {ex.Message}",
        //                "Echec",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error
        //            );
        //        return -1;
        //    }
        //}

    }
}
