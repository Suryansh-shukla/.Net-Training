using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPatientService:IRepository<Entities.Patient>
    {
        void AddPatient(Patient patient);
        List<Doctor> GetAllPatients();
        Doctor GetPatientById(int Id);
        void UpdatePatient(int Id, Patient patient);
        void DeletePatient(int Id);
    }
}
