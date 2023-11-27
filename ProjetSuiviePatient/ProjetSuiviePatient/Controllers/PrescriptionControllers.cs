using ProjetSuiviePatient.DAO;
using ProjetSuiviePatient.Entities;
using ProjetSuiviePatient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSuiviePatient.Controllers
{
    public class PrescriptionControllers
    {
        PrescriptionService prescriptionService;

        public PrescriptionControllers()
        {
            prescriptionService = new PrescriptionService();
        }

        public Prescription Save(DateTime DatePrescription, string PosologieGenerale, string Instruction, int MedecinID, int PatientID)
        {
            Prescription prescription = new Prescription
            {
                DatePrescription = DatePrescription,
                PosologieGenerale = PosologieGenerale,
                Instructions = Instruction,
                MedecinID = MedecinID,
                PatientID = PatientID
            };
            return prescriptionService.Save(prescription);
        }

        public List<Prescription> FindAll()
        {
            return prescriptionService.FindAll();
        }

        public Prescription Update(Prescription prescription)
        {
            return prescriptionService.Update(prescription);
        }

        public int Delete(int id)
        {
            return prescriptionService.Delete(id);
        }

        public bool Exists(int id)
        {
            return prescriptionService.Exists(id);
        }

        public Prescription FindById(int id)
        {
            return prescriptionService.FindById(id);
        }

        public int PatientID()
        {
            return prescriptionService.PatientID();
        }

        public int MedecinID()
        {
            return prescriptionService.MedecinID();
        }
    }
}
