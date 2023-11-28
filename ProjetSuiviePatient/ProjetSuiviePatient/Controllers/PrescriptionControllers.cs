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
        Medecin Medecin;
        Patient Patient;
        public PrescriptionControllers()
        {
            prescriptionService = new PrescriptionService();
            Medecin = new Medecin();
            Patient = new Patient();
        }

        public Prescription Save(DateTime DatePrescription, string PosologieGenerale, string Instruction, Medecin medecin, Patient patient)
        {
            Prescription prescription = new Prescription
            {
                DatePrescription = DatePrescription,
                PosologieGenerale = PosologieGenerale,
                Instructions = Instruction,
                Medecin = Medecin,
                Patient = Patient
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

        public Prescription FindByName(string name)
        {
            return prescriptionService.FindByName(name);
        }

        public List<Prescription> FilterByName(string name)
        {
            return prescriptionService.FilterByName(name);
        }
    }
}
